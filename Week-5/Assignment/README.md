# Notes

xyz() --> this means that xyz is a function or a method
xyz   --> this means that xyz is an OBJECT or a VARIABLE

```
ApplianceItem.ApplianceTypeEnum

                    C#
                    |
                   Item
                  /    \
        GroceryItem:Type
 | |
 M F
```

## Q ->  why not Item.GroceryItem? 
GrocerItem is A TYPE of Item, it is NOT A Item
Since item is abstract

 Student Monika = new Student (
    F,
    "Monika",
    1234
 )

 Monika.Gender == F ==> should return True
Gender.F = F

Item item = {
    Description,
    Price,
    SKU
}

Item aeroplane = { "Aeroplane", "5M", "0900" }
aeroplane.desc = Aeroplane
aeroplane.price = 5,000,000

GroceryItem gItem = {
    description,
    price,
    Sku,
    expiration date
}

GroceryItem milk = { "4L Milk", 4, 5677, 02-17-2023 }
milk.des = 4L Milk
milk.expDate = 4L Milk









## build up a list of items containing grocereies and applicance
List<Item> itemList = new List<Item>();

- get the data from the csv
- parse the data
- check if the item is a groceryItem or a applianceItem
- set appliance type accordinly

- for an example
GroceryItem gItem = new GroceryItem(
"bogus desc",
999.99f,
"123456",
DateTime.Now
);

ApplianceItem aItem = new ApplianceItem(
"bogus desc",
9123.99f,
"99585",
ApplianceItem.ApplianceTypeEnum.Oven  // example oven appliance item
);

- while parsing, check if there's a match for any of the ApplianceTypeEnums
- if yes - then use ApplianceItem.ApplianceTypeEnum.  <-- define the type that matched

String[] lines = gettingCSVDate();
foreach (String line in lines) {
- parsing

## look at the 4th column of input -> either format 2019-10-14 OR Washer
- to check if this is grocery item or a appliance
- check if 4th column contains '-'
- if yes - its a datetime
- if no - its an appliance


if (line[4] is type string) { //cheching the datatype of column 4
- then define a new appliance item
} else {

- this is datetime
- parse this to datetime
- then define a new grocery item
}}

## adding grocery item to the list
itemList.Add(gItem);
itemList.Add(aItem);

return itemList;


## Same thing but just writting two different ways

```
return this.Sum(i => i.Price);
```

```
double sum;
foreach (var val in this) {
     sum += item.Price;
}
return sum;
```

## using double in ItemList since max price is 999,999.99 which is supported by float
- but 999,999.99 * size_of_list could cause a bit overflow in float...
- quesiton: should we be worried about list of items causing a bit overflow in float datapoint?
- because lets say we have multiple list items with max price, float would only be able to hold so many...  3.4 × 10^38
- No - float
- yes - double
       


## Item Class notes
List<Integer> numbers;

`unsorted`
{ 1, 4, 3, 6, 7, 8, 2 }

`sorted - desc order`
numbers.sort();
{ 8, 7, 6, 4, 3, 2, 1 }

- our case - each element has name, price, type / exp date

`unsorted - natural order`
List<Item> items;
{ 
    ( Crystal Clean Dishwasher, 800, Dishwasher ),
    ( 4L Milk, 4, 17-02-2023 ),
    ( Insignia Mini Fridge, 70, Refrigrator )
}

- sort - desc based on price
- acc to c# - > item has ~ 10 bytes, address of where the item is in memory
items.sort(); // err => idk what is items so idk how to sort

- internal sort in c# -> can take primitive datatypes
item1.compareTo(item2)
milk.compareTo(Dishwasher) -> -1
{ milk, fridge, dishwasher }

{dishwasher, fridge, milk }*/