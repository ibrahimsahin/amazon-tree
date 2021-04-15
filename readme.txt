In this experiment we will have a chance to learn  trees, a very important data structure concept, 
and manipulating of it. In computer science, a treeis a widely-used data structure that emulates a 
tree  structure  with  a  set  of  linked  nodes.  It  is  an acyclic  and  connected  graph.  Most  of  the 
literatures  also  include  the  constraint  that  a  graph's  edges  must  be  undirected  to  be  a  tree 
In this work you’re expected to implement a programthat manipulates the product/category tree 
of  amazon.com  web  site.   You’ll  be  given  two  input  files:  “urunler.txt”,  containing  a  sample 
subset  of  categories  and  products  of  amazon.com  and “islem.txt”  which  contains  some 
commands  that  will  be  executed  against  products/categories

Your program will construct this structure by reading the plain text file (urunler.txt)  given to 
you  and  make  some  operations  on  this  structure  by  reading  and  processing  the  commands  in 
“islem.txt”.  Every  command  result  must  be  outputted  to  “output.txt”.  The  filenames  are 
constant and your program mustn’t take any parameter at startup. However, no GUI is expected from you. Therefore, your only work is to read input files, process them and reflecting the results 
to output file

Category  entities  consist  of  3  attributes  while  products  consist  of  5  attributes.  Category  and 
product entities can be given in mixed order and there is no guarantee that any product can be 
given after creation of parent category. Therefore,your logic must handle this situation. Also a 
category  can  hold  infinite  number  of  products  and  categories.  By  the  way,  the  root  category’s 
name  is  “Amazon”  so  all  top  level  categories  and  products  must  be  located  under  “Amazon” 
category. 
Your second input file, “islem.txt” consists of some commands that will process on “urunler.txt”. 
Result of every operation must exist in outpu.txt. Example inputs and output will given further in 
this document. Here is the list of commands:

RISE:   Raises the products’ prices. 
   RISE <category name(s)> <product name(s))> <amount to add> 
   Ex: RISE NOD_32 Microsoft_Mouse Books 14 
   Ex: RISE Software MixBlend 12 
RISE command rise all the sub-items of a parent category. Also you should 
consider  that  a  product’s  price  can  only  be  raised  at  most  one  time  in  a 
command  session.  This  means  that  your  logic  should  be  aware  of  price 
update times and never allows any other price change of a product in same 
command session. 
DISCOU-T:  Discounts the products’ prices. 
   DISCOUNT <category name(s)><product name(s))><amount to discount> 
   Ex: DISCOUNT Halo_3 Software NOD_32 13 
   Ex: DISCOUNT Textbooks 12 
DISCOUNT  command  is  the  reverse  version  of  RISE  command.  All  the 
restrictions  and  rules  are  exists  for  the  DISCOUNT  command  as  well  as 
RISE. 
SELL:   SELL stands for to sell one specific product or a series of products. 
   SELL <product name(s))> <# of products to sell> 
   Ex: SELL NOD_32 Microsoft_Mouse 5 
SELL  command  stands  for  selling  operation.  It  must  check  the  stock 
availability of product(s) and then sell requested  numbers of good given in 
command text. If the stock quantitiy of that product is lower than demand 
than it must raise an error message that denotes this error. 
RETUR-: RETURN, returns the product(s) to back with specified quantitiy. 
   RETURN <product name(s))> <# of products to return back> 
   Ex: RETURN Halo_3 Microsoft_Mouse 2 
RETURN command stands for refunding. It must check  the selling list of 
product(s) and then return requested numbers of good given in command 
text. If the return quantity of that product is lower than selling than it must 
raise an error message that denotes this error. Otherwise it must decrease 
the selling number and return the product (s) to stock again. 
LIST:   LIST, lists the contents of category in a tree-like fashion style. 
   LIST <category name(s))> 
   Ex: LIST Home_&_Garden 

Ex: LIST Books Amazon 
The original price, current price and stock number of every product must 
be denoted in the syntax form of “product name [OP CP SN ]” where OP 
stands for original price, CP for current price andfinally SN for stock 
number respectively. 
REPORT:  REPORT command reports the summary and details of purchases in given 
product categories. 
   REPORT <category name(s))> 
   Ex: REPORT Computers Books 
REPORT  command  must  dump  all  the  purchased  items’  information  and 
calculate total profit, loss and revenue. Revenue is the total money made by 
selling the goods. 
