# Lab09-Linq-in-Manhattan

## Summary
This application is to demonstate using LINQ queries methods to search data from a JSON file. 

**Approach**
 We first used the starter code to convert json data into an array of objects.
 Then we utlized Test Driven Development to create tests to search the array of objects 
 for the properties requested. We took advatange of both Linq queries ` var query = from...select...where`
 and Linq methods ` objectArray.Where(...).Select(...).Distinct().