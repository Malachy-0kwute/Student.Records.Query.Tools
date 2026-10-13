# Student.Records.Query.Tools

- The purpose of the application
This is a class project that aims to solidify LINQ knowledge. 
It is a simple application that enables users to search, sort and filter information based on query passed in.

- How student records are created or loaded
  Student record is created and seeded when application first loads.
  
- How to run each query
  There are 4 different query modes in the application. They include, Searching or filtering record by id, gpa, program
  and also sorting available information by id, firstname, lastname or records above a specified gpa.
  To run a query you first select the mode you desire and the enter query parameter like sorting using firstname or filtering using id etc.
  
- Which LINQ operators are included
  findall()
  FirstOrDefault()
  .ToList()
  .OrderBy()
  
- How summary information is calculated
  summary is calculated and displayed at the bottom of main window. Every filter and searches are recalculated and updated
  
  
- Any known limitations
  Unable to convert UI object ListViewItemCollection to list type to run query on it
