# Brewery Arc

----

Design Document 

Bhawesh Joshi 
Jacob Joseph 
Pallabi Das 
Parul Ranjan 
Trishita Aditya 

## Introduction

My BreweryArc Website will help you locate any Brewery you want based on your own personal preference. 

- View a list of all the breweries present 

- Select a Letter and get all details of a brewery starting with that letter 

- View Brewery Details based on a name , city or type 

## Data Feeds 

[List of Breweries](https://api.openbrewerydb.org/breweries) 

[Get Breweries](https://api.openbrewerydb.org/breweries/1234)

## Functional Requirements 

### Requirement 100.00: List of Breweries 

#### Senario

As a user interested in breweries, I want to be able to see a list of all the breweries available and look up any brewery based on the brewery type and brewery name.

#### Dependencies 

Brewery search data are available and accessible. 

#### Assumptions 

- All the breweries are in United States or Ireland. 

- All the names are in English. 

#### Examples 
1.1


**Given** a feed of country data is available

**When** I search for breweries list of from the given country 

**Then** All the breweries get listed with these attribute:

    Name: 12 Acres Brewing Company 
    City: Killeshin 
    State: Laois  
    Country: Ireland 

1.2

**Given** A feed of brewery data is available 

**When** I search for “10-56-brewing-company-knox” 

**Then** I should receive at most one result with these attributes: 

    Name: 10-56 Brewing Company
    Brewery: micro 
    Address: 400 Brown Cir    
    City: Knox 
    State: Indiana 
    Zip Code: 46534 
    Country: United States
    
 1.3
 
**Given** A feed of brewery data is available 

**When** I search for “Large”(Brewery type) 

**Then** I should receive at least one result with these attributes: 

    Name: 10 Barrel Brewing Co - Bend Pub 
    Brewery Type: large 
    Address: 62950 NE 18th St 
    City: Bend 
    State: Oregon 
    Zip Code: 97701 
    Country: United States 
    
1.4

**Given** A feed of brewery data is available 

**When** I search for “Denver”(city)

**Then** I should receive at least one result with these attributes: 

    Name: 10 Barrel Brewing Co - Denver 
    Brewery Type: large 
    Address: 2620 Walnut St 
    City: Denver 
    State: Colorado 
    Zip Code: 80205-2231 
    Country: United States 
    
1.5

**Give**n A feed of plant data is available 

**When** I search for “dfhdjjdjjdjdjd”(gibberish)

**Then** I should receive zero results (an empty list)


### Scrum Roles

  -DevOps/Product Owner/Scrum Master: Bhawesh Joshi 

  -Frontend Developer: Jacob Joseph and Pallabi Das 

  -Integration Developer: Parul Ranjan and Trishita Aditya 

### Weekly Meeting 

  Friday at 3:45 PM In-Person 
