# _Word Frequency_

#### _c# Exercise for Epicodus, 07.08.2016_

#### By _**Bo Zhao**_

## Description

_a website in Nancy that uses a method to return how frequently a word appears in a given string._

## Specs
1. _It finds out how frequently a word appears in a string_
  * input: "password", "password is password"
  * output: 2
2. _It finds out how frequently a upper case word appears in a lower case string_
  * input: "PASSWORD", "password is password"
  * output: 2
3. _It finds out how frequently a lower case word appears in a upper case string_
  * input: "password", "password is PASSWORD"
  * output: 2
4. _It finds out how frequently a word appears in an empty string_
  * input: "password", ""
  * output: 0
5. _It finds out how frequently a word appears in a string with punctuation_
  * input: "password", "password is 'password'!"
  * output: 2

## Setup/Installation Requirements

* _Set up git project for Windows_
* _Clone this repository_
* _Set up dependencies in PowerShell by typing "dnu restore"_
* _Start the kestrel web server by typing "dnx kestrel"_
* _Open your web browser of choice to localhost:5004_

## Technologies Used

* _c#_
* _Nancy_
* _Razor_
* _html_

### License

*This software is licensed under the MIT License*

Copyright (c) 2016 **_Bo Zhao_**
