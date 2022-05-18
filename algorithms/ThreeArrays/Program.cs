using System.Linq;
using System.Collections.Generic;

// Given 3 arrays with 3 values in each. Sort them
var arr1 = new [] { 1, 3, 2 };
var arr2 = new [] { 5, 9, 7 };
var arr3 = new [] { 11, 13, 15 };

var totalArr = arr1.Union(arr2)
    .ToArray()
    .Union(arr3)
    .ToArray();

// First sort each one
Array.Sort(totalArr);

// Print
for (int j = 0; j < totalArr.Length; j++) Console.WriteLine(totalArr[j]);