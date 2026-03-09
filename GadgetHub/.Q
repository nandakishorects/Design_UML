Description





Scenario:

GadgetHub, an e-commerce platform for high-tech gadgets, needs a system to categorize gadgets based on customer selection. The system must dynamically create instances of specific gadget types (MobileGadget, LaptopGadget) based on user input. Using the Factory Pattern, the application will generate the appropriate gadget type and display a confirmation message for the selection.

Your task is to implement this system using the Factory Pattern to support different gadget types and confirm the user's choice.

 

Functionality:

In public class Gadget, implement the following public field:

Datatype

Field Name

string

gadgetName

 

In public class MobileGadget which inherits Gadget class,

-       Implement a public constructor which takes a string argument for name and set the field Name.

-       Print "You have chosen Mobile Gadget and its name is <<name>>" after setting the field Name.

In public class LaptopGadget which inherits Gadget class,

-       Implement a public constructor which takes a string argument for name and set the field Name.

-       Print "You have chosen Laptop Gadget and its name is <name>" after setting the field Name.

Implement the following public method in class GadgetFactory,

Method Name

Method Description

public static Gadget GetGadget()

This static method returns an instance of either MobileGadget or LaptopGadget based on the gadget type.

If the gadget type is invalid, print "Invalid gadget type".

Inputs are case-insensitive.

 

In the Program class, implement the below-given Method.

Method:

public static void Main(string[] args)

Description:

Gather the user input for the gadget type and name.
Call the method GetGadget from GadgetFactory to create the appropriate gadget.
If the gadget type is mobile create an instance for MobileGadget and print "You have chosen Mobile Gadget and its name is {gadgetname}".
If the gadget type is laptop create an instance for LaptopGadget and print "You have chosen Laptop Gadget and its name is {gadgetname}".
Refer to Sample input and output.

 

Note:

- Keep all methods public.

- Inputs should only be gathered in the Main method.

- Do not use Environment.Exit() to terminate the program. 

- Do not change the given code template.

- In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user and the rest of the text represents the output.

 

Sample Input 1:

Enter the gadget type (mobile/laptop):

mobile

Enter the name of the gadget:

iPhone 13

Sample Output 1:

You have chosen Mobile Gadget and its name is iPhone 13

Gadget created: iPhone 13

 

Sample Input 2:

Enter the gadget type (mobile/laptop):

laptop

Enter the name of the gadget:

MacBook Pro

Sample Output 2:

You have chosen Laptop Gadget and its name is MacBook Pro

Gadget created: MacBook Pro

 

Sample Input 3:

Enter the gadget type (mobile/laptop):

camera

Enter the name of the gadget:

Z50

Sample Output 3:

Invalid gadget type

