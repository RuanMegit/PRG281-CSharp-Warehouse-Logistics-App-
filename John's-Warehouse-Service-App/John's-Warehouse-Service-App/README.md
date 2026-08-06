-John's Warehouse Service App
Project Overview

John's Warehouse Service App is a console-based warehouse management system developed in C# using Object-Oriented Programming (OOP) principles. The application simulates the daily operations of a warehouse by managing inventory, shipments, employees, vehicles, and warehouse events.

The project has been designed to demonstrate software engineering concepts such as abstraction, encapsulation, inheritance, polymorphism, exception handling, event-driven programming, and background process simulation.



-Domain-Specific Rule
Warehouse Capacity Constraint

The warehouse has a maximum storage capacity.

The total quantity of products stored in the warehouse may never exceed the defined warehouse capacity. If adding new inventory would exceed this limit, the system will reject the operation and notify the user.

This rule simulates a real-world warehouse where storage space is limited.



-Custom Feature
Product Movement History

Every inventory movement is automatically recorded.

Whenever stock is added to or removed from the warehouse, the system saves the transaction in a movement history log.

Example:

12/08/2026
Added 50 Chairs

13/08/2026
Removed 10 Chairs

15/08/2026
Added 20 Desks

This feature allows users to review inventory changes over time and provides a simple audit trail for warehouse operations.


-Technologies
C#
.NET Console Application
Object-Oriented Programming (OOP)


-OOP Concepts Demonstrated
Abstraction
Encapsulation
Inheritance
Polymorphism
Custom Exceptions
Event Handling
Interfaces (where applicable)

-Person 1
Create all the neccasery claasses/ Objects/ Fields