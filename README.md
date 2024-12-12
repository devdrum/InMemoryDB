InMemoryDB - a sample program storing a dictionary of key-value pairs and handling changes via transactions similar to a DB
=============================================================

Welcome to the source repository for InMemoryDB. InMemoryDB is a c# class that keeps track of a dictionary, and allows users the following functironality:

Get - retrieves value for provided key
Put - Inserts/Updates provided key/value pair (requires transaction in process)
Begin_Transaction - begins a transaction, this is followed by adds/updates, as well as a rollback or commit (requires transaction not already be in progress)
Commit - commits changes since transaction begin (requires transaction in progress)
Rollback - reverts any changes made since transaction has begun (requires transaction in progress)

Getting Started for Developers:
-------------------------------

These instructions are made to assist developers in getting started with InMemoryDB so they can contribute to the repository. Please verify system prerequisites are met before trying to build.

IDE System Requirements:
------------------------

* Windows OS environment
* .net Core 8.0 framework
* Visual Studio 2022 or newer

Build Instructions:
-------------------

* Open Visual Studio
* Clone GitHub Repository using Visual Studio, using the link in the green code button above. Alternatively, you can download the repository to your machine and open the solution file located in /src/Greenshot.sln.
* Choose Build->Build Solution in Visual Studio to build binaries.
* Verify all components are built successfully.
* You are ready to start using InMemoryDB

How to modify assignment:
------------------

* Modify requirements to include multiple tables, so student has to manage multiple dictionaries for each table. 
* Have students create a library so that assignment can be graded with auto-scripts and an internal application that calls the library. However, this could create a need to restrict the language used.
* Or, modify the program requirements to accept command line arguments, which would preserve the freedom for the student to choose their own language. Graders might need a specific architecture/OS based on chosen language.
* With the CLI method, assignment can be graded using scripts or batch files. 
