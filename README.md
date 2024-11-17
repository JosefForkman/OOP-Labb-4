# OOP Labb 4

## Extra utmaningar

- [x] Skapa en klass som heter `MenuItem` med följande struktur (denna klass kommer inte behöva ändras):
```C#
// I denna klass använder vi auto-implemented properties
public int Id { get; set; }
public string Name { get; set; }
public decimal Price { get; set; }

public MenuItem(int id, string name, decimal price)
{
    Id = id;
    Name = name;
    Price = price;
}

public override string ToString()
{
    return $"{Name} - {Price:C}";
}
```
- [x] Skapa en klass som heter `Order` med följande grundstruktur (denna klass kommer du troligtvis behöva bygga ut med fler metoder):

```C#
// I denna klass använder vi i stället private fields
static int orderIdCounter = 1;
private int _orderId;
private List<MenuItem> _orderItems;
private int _tableNumber;

public Order(List<MenuItem> orderItems, int tableNumber)
{
		// Automatiskt skapande av id
    _orderId = orderIdCounter;
    orderIdCounter++;
    _orderItems = orderItems;
    _tableNumber = tableNumber;
}
```
- [x] Implementera en klass `Restaurant` som använder:
    - [x] En List<T> för att representera menyn
    - [x] En Queue<T> för att hantera beställningar (av klassen Order)
- [x] Restaurant-klassen ska du bygga själv och följande metoder ska ingå:
    - [x] `AddtoMenu(MenuItem menuItem)`: Lägger till en ny maträtt i menyn och loggar detta till konsolen.
    - [x] `ShowMenu()`: Skriver ut alla maträtter i menyn till konsolen.
    - [x] `CreateOrder(Order order)`: Lägger till en ny beställning i kön och loggar detta till konsolen.
    - [x] `HandleOrder()`: Hanterar (tar bort) den första beställningen i kön och loggar detta till konsolen.
    - [x] `ShowOrders()`: Skriver ut alla beställningar i kön till konsolen.
    - [x] `ShowNextOrder()`: Skriver ut beställningen som är näst i kön till konsolen.
    - [x] `ShowOrderCount()`: Skriver ut antalet beställningar i kön till konsolen.

(Tips! Skapa en metod i Order-klassen som du kan kalla på för att skriva ut en beställning. Den kan du sedan använda i alla metoder som skriver ut en eller flera beställningar.)

### Simulering
1. ~~Skapa ett nytt objekt av Restaurant-klassen.~~
2. ~~Lägg till fyra olika rätter i menyn.~~
3. ~~Skriv ut menyn.~~
4. ~~Skapa 3 st nya ordrar, med minst två olika rätter i varje, och lägg till dem i orderkön (du kan hitta på bordsnummer för beställningarna).~~
5. ~~Visa alla aktuella ordrar.~~
6. ~~Visa antalet ordrar i kön.~~
7. ~~Visa nästa order på kö.~~
8. ~~Hantera en order.~~
9. ~~Visa antalet ordrar i kön.~~
10. ~~Lägg till en ny order.~~
11. ~~Visa antalet ordrar i kön.~~
12. ~~Hantera två ordrar.~~
13. ~~Visa antalet ordrar i kön.~~
14. ~~Visa nästa order på kö.~~
15. ~~Hantera en order.~~
16. ~~Visa antalet ordrar i kön.~~

## Extra utmaningar
- [x]  Lägg till en metod som flyttar en valfri order längst fram i kön.
- [ ]  Lägg till en funktion som grupperar beställningar från samma bord. När en ny beställning läggs till, placera den direkt efter andra beställningar från samma bord om sådana finns.
- [ ]  Implementera en metod (eller ändra i befintliga) som låter användaren markera en beställning som "brådskande". Dessa beställningar ska automatiskt placeras först i kön.
- [ ]  Sätt en maxgräns för antalet beställningar i kön. Om kön är full när en ny beställning läggs till, placera den i en separat "väntande" lista. (Kom ihåg att också implementera funktionalitet för att fylla på kön när lediga platser dyker upp.)
- [ ]  Lägg till möjligheten att göra specialbeställningar (t.ex. allergianpassningar) och markera dessa i kön.
- [ ]  Implementera en funktion som låter användaren hantera flera beställningar samtidigt (t.ex. markera alla beställningar från ett visst bord som klara).
- [ ]  Lägg till en tidsstämpel för varje beställning och implementera en funktion som sparar data för hur lång tid det tar för varje beställning att bli färdig.