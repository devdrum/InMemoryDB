using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InMemoryDB
{
    private Dictionary<string, int> _current;
    private Dictionary<string, int> _pending;
    private bool _transactionInProgress = false;




    public InMemoryDB()
    {
        _current = [];
        _pending = [];
    }


    public int? Get(string key)
    {
        if (_current.TryGetValue(key, out int value))
        {
            Console.WriteLine(value.ToString());
            return value;
        }
        else
        {
            Console.WriteLine("NULL");
            return null;
        }
    }
    public void Put(string key, int value)
    {
        if (_transactionInProgress)
        {
            _pending[key] = value;
        }
        else
        {
            Console.WriteLine("ERROR: A transaction is not in progress");
        }
    }
    public void Begin_Transaction()
    {
        if (_transactionInProgress)
        {
            Console.WriteLine("ERROR: A transaction is already in progress");
        }
        else
        {
            _transactionInProgress = true;
            _pending = new Dictionary<string, int>(_current);
        }
    }
    public void Commit()
    {
        if (!_transactionInProgress)
        {
            Console.WriteLine("ERROR: A transaction is not in progress");
        }
        else
        {
            _current = new Dictionary<string, int>(_pending);
            _transactionInProgress = false;
        }
    }
    public void Rollback()
    {
        if (!_transactionInProgress)
        {
            Console.WriteLine("ERROR: A transaction is not in progress");
        }
        else
        {
            _pending = new Dictionary<string, int>(_current);
            _transactionInProgress = false;
        }
    }


}

