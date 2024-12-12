// See https://aka.ms/new-console-template for more information
InMemoryDB inmemoryDB = new();

// should return null, because A doesn’t exist in the DB yet
inmemoryDB.Get("A");

// should throw an error because a transaction is not in progress
inmemoryDB.Put("A", 5);

// starts a new transaction
inmemoryDB.Begin_Transaction();

// set’s value of A to 5, but its not committed yet
inmemoryDB.Put("A", 5);

// should return null, because updates to A are not committed yet
inmemoryDB.Get("A");

// update A’s value to 6 within the transaction
inmemoryDB.Put("A", 6);

// commits the open transaction
inmemoryDB.Commit();

// should return 6, that was the last value of A to be committed
inmemoryDB.Get("A");

// throws an error, because there is no open transaction
inmemoryDB.Commit();

// throws an error because there is no ongoing transaction
inmemoryDB.Rollback();

// should return null because B does not exist in the database
inmemoryDB.Get("B");

// starts a new transaction
inmemoryDB.Begin_Transaction();

// Set key B’s value to 10 within the transaction
inmemoryDB.Put("B", 10);

// Rollback the transaction - revert any changes made to B
inmemoryDB.Rollback();

// Should return null because changes to B were rolled back
inmemoryDB.Get("B");

