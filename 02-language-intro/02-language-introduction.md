---
marp: true
paginate: true
theme: default 
header: ![h:35](../imgs/starwit.png)
footer: 'Starwit Technologies GmbH | C# | 1. Tools, Setup & .NET'
---

<style>
header {
  text-align: right;
  font-size: 0.7rem;
  color: #bbb;
  margin: 20px;
  left: 0px;
  right: 0px;
  padding-top: 5px;
}
footer {
  font-size: 0.9rem;
  color: #666;
}
section.lead {
  text-align: center;
  margin-bottom: 40px;
}
section.lead h2 {
  font-size: 2.5rem;
}
section {
  font-size: 1.5rem;
}

section.linked footer {
  display: none;
}
section.linked header {
  display: none;
}
section.quote {
  font-size: 0.7rem;
  text-align: center;
  font-style: italic;
  color: #555;
}

h1 {
  position: absolute;
  top: 10px;
  padding-top: 15px;
  text-transform: uppercase;
  font-size: 2.0rem;
  font-weight: 500;
  color: #2B5A6A;
}

h2 {
  font-size: 2.0rem;
  font-weight: 500;
  color: #2B5A6A;
  margin-top: 30px;
  margin-bottom: 15px;
}
a {
  color: #3A9FC1;
}
a:hover {
  color: #1E708B; 
  text-decoration: underline; 
}

</style>
<!-- _class: lead -->
## 2. Language Introduction

---
# Agenda

* Language Introduction - Concepts, Structures, Data, Parameter
    * building blocks
    * built-in types
    * C# Operator
* First real example 
* Types of .NET applications 
* Concept Object Orientated Programming 

---
# Language Introduction
## Variables
* A variable:
    * holds a value
    * has a data type
    * is created in a declaration statement
* coding convention for naming: 
    * starting with lower case
    * using camel case

---
# Language Introduction
## Data Types
Define 
* Size and location in memory
* Data range
* Valid operators

of/for a variable

## Constants

* using key-word `const`, e.g. `const int myInt = 10`

---
# Language Introduction
## Control Flow
* Codeblock: 
    * contains several lines of code
    * surrounded with `{ }`
* boolean expression: 
    * returns a boolean value
    * operators: <, >, <=, >=, ==, !=

---
# Language Introduction
## Control Flow
* Condition: if statement (if, else if, else)
* Loop: 
    * for
    * foreach
    * while
    * do-while
* Switch: case statement
* break / continue

> more information and code examples can be find [here](https://www.w3schools.com/cs/cs_conditions.php)

