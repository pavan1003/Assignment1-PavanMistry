# HTTP 5125 Assignment 1

## Introduction

This repository contains an ASP.NET WebAPI project for the HTTP 5125 Assignment 1. The project includes controllers to implement various functionalities as described in the assignment.

## Controller 1: AddTenController
### GET http://localhost/api/AddTen/{id}
#### Summary: Receives an input integer number and returns 10 more than that number.
#### Param name: id => The input integer that gets added by 10.
#### Returns: The result of adding 10 to the input number.
#### Examples:
GET /api/AddTen/21 => 31  
GET /api/AddTen/0 => 10  
GET /api/AddTen/-9 => 1  

## Controller 2: SquareController
### GET http://localhost/api/AddTen/{id}
#### Summary: Receives an input integer number and returns the square of that number.
#### Param name: id => The input integer to be squared.
#### Returns: The square of the input number.
#### Examples:
GET /api/Square/2 => 4  
GET /api/Square/-2 => 4  
GET /api/Square/10 => 100  

## Controller 3: GreetingController
### POST http://localhost/api/Greeting
#### Summary: Returns the string "Hello World!".
#### Returns: The greeting string "Hello World!".
#### Examples:
POST /api/Greeting => "Hello World!"  

### GET http://localhost/api/Greeting/{id}
#### Summary: Receives an input integer number and returns a greeting string based on the input number of people.
#### Param name: id => The number of people to greet.
#### Returns: The greeting string with the specified input number of people.
#### Examples:
GET /api/Greeting/3 => "Greetings to 3 people!"  
GET /api/Greeting/6 => "Greetings to 6 people!"  
GET /api/Greeting/0 => "Greetings to 0 people!"  

## Controller 4: NumberMachineController
### GET http://localhost/api/NumberMachine/{id}
#### Summary: Receives an input integer number and applies four mathematical operations on it. Truncates the result to an integer.
#### Param name: id => The input number to perform four mathematical operations on.
#### Returns: The result of four mathematical operations (addition, subtraction, multiplication, division).
#### Examples:
GET /api/NumberMachine/10 => 82  
GET /api/NumberMachine/-5 => 0  
GET /api/NumberMachine/30 => 192  

## Controller 5: HostingCostController
### GET http://localhost/api/HostingCost/{id}
#### Summary: Receives an input number of days and calcualtes the total cost of hosting according to fortnights.
#### Param name: id => Represents number of days
#### Returns: Returns a string with fortnights cost, HST and total cost of hosting
#### Examples:
GET /api/HostingCost/0  => "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"  
GET /api/HostingCost/14 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"  
GET /api/HostingCost/15 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"  
GET /api/HostingCost/21 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"  
GET /api/HostingCost/28 => "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.15 CAD", "Total = $18.65 CAD"  
