# S.O.L.I.D opgave

## Opgave 1
## Sinngle Responsibility
Dele henholdsvis database og log/fejl håndtering over i deres egen klasse, og deraf refere til dem/kalde dem.

## Opgave 2
## Open/Closed
Customer bliver base/super klasse, hvor efter der bliver oprettet 2 nye klasser, henholdsvis NewCustomer, og ExistingCustomer, som begge arver fra Customer.

- Nu man extende koden alt det man vil, ved at arve fra superklassen

## Opgave 3
## Liskov Substitution
Vi fjerner metoden `public override void Add(Database db)` på Enquriy så den fungere på samme måde som de andre customers.

- Hvis `Add()` kaster en exception, går det imod superklassens hensigt, og de to kan ikke ombyttes, uden der er sideeffects

## Opgave 4
## Interface Seggregation
`void Add()` blev fjernet fra `ICustomerImproved` interfacet og istedet arver den fra ICustomer.
Det er gjordt for at holde interfacene så små så muligt, så dem der skal bruge dem, kun bruger dem de har behov for

## Opgave 5
## Dependency Inversion
Der blev oprettet et `ILogger`-interface, som `FileLogger` implementerer, og som `Customer` får injected. De er nu begge afhængige af en abstraktion i stedet for at `Customer` har en direkte afhængighed på `FileLogger`.