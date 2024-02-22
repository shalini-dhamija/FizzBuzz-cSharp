Shalini
shalini_32033

Nandini Polavarapu — 17/01/2024 15:54
https://regexr.com/
RegExr
RegExr: Learn, Build, & Test RegEx
RegExr is an online tool to learn, build, & test Regular Expressions (RegEx / RegExp).
RegExr: Learn, Build, & Test RegEx
Lou — 17/01/2024 15:59
Attachment file type: acrobat
W1-D2-email-extraction.pdf
357.77 KB
Lou — 18/01/2024 11:28
https://techswitch.atlassian.net/wiki/spaces/0RC/pages/891060240/04+-+Bus+Board
Log in with Atlassian account
Log in to Jira, Confluence, and all other Atlassian Cloud products here. Not an Atlassian user? Sign up for free.
Vicky — 18/01/2024 11:55
Highly recommend this browser extension: JSONvue, which sorts the format nicely when you check the JSON response in the browser: https://chromewebstore.google.com/detail/jsonvue/chklaanhfefbnpoihckbnefhakgolnmc?pli=1
JSONVue
Validate and view JSON documents
Image
Lou — 19/01/2024 10:41
Attachment file type: acrobat
2-errors-logging-packages.pdf
460.81 KB
Lou — 24/01/2024 10:26
Attachment file type: acrobat
2-more-testing.pdf
164.25 KB
Lou — 25/01/2024 13:54
Attachment file type: document
Extending_a_class.pptx
41.03 KB
Lou — 30/01/2024 10:46
Attachment file type: acrobat
2-CSS.pdf
320.01 KB
Shalini — 02/02/2024 10:59
Hi Lou, please share today's ppt. thanks
Lou — 02/02/2024 11:00
Attachment file type: acrobat
1-intro-to-react.pdf
359.44 KB
Lou — 05/02/2024 13:47
Attachment file type: acrobat
3-testing-in-react.pdf
248.13 KB
Lou — 06/02/2024 12:01
Attachment file type: acrobat
09-MyFace-React-01-SASS.pdf
354.48 KB
Attachment file type: acrobat
2-further-react.pdf
263.56 KB
Nandini Polavarapu — 06/02/2024 13:37
Hi,
 I found the following article regarding Functional components with typescript
https://felixgerschau.com/react-typescript-components/
How to create React components with TypeScript | Felix Gerschau
Using TypeScript together with React has proven to be a powerful combination. Some people are afraid to move to TypeScript because they…
How to create React components with TypeScript | Felix Gerschau
Lou — 06/02/2024 15:52
import React from "react";
import "./styles.css"

export interface ImageThumbnailProps {
    imageUrl?: string;
    imageSize: string;
Expand
index.tsx
1 KB
Lou — 08/02/2024 10:30
form example
import { useState, FormEventHandler, ChangeEventHandler } from "react";
import { NewUserModel } from "../../models/userModel";

export function MyForm() {
    const [inputs, setInputs] = useState<NewUserModel>({
        name: undefined,
Expand
index.tsx
2 KB
Lou — 12/02/2024 10:02
https://techswitch.atlassian.net/wiki/spaces/0RC/pages/890994719/10+-+Mars+Mission
Log in with Atlassian account
Log in to Jira, Confluence, and all other Atlassian Cloud products here. Not an Atlassian user? Sign up for free.
Lou — 12/02/2024 14:59
two HLDs for MyFace design on user details

HLD for user posts on my face
show 6 posts a user has created, with a button to to show more posts
on mobile it's on one line and will scroll, but still has a button to show more posts
question: is there a limit of how many posts to show? what happens if a user has hundreds of posts? is it the latest six posts? or the most popular?
need: user details page, get posts list endpoint
will create a new post thumbnail that can be reused in liked/disliked posts
will create a post list that can be reused in liked/disliked posts
need to think about how padding will look on different desktop sizes

HLD for user liked posts on my face
// assuming questions for user post have been answered and user posts is done
reuse post thumbnail and post list
question: is this also latest or most liked post?
so note that they are different sizes, not all HLDs are massive, a HLD will contain what the ticket will cover, anything to note (like the mobile differences and thinking about padding), any questions you have that you need answers to, what you are going to use and create, I haven't said exactly how I'm going to do things but generally how I will go about it
Dani — 13/02/2024 10:35
https://www.canva.com/design/DAF8nmdhc3E/qrhK24EIUUXDUEoG2aNWjw/edit?utm_content=DAF8nmdhc3E&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton
Canva
Webpage Design Ideas
Webpage Design Ideas
Lou — 13/02/2024 10:43
I've just googled and yes Trello is having some performance issues this morning that they know about and are working on so don't worry if Trello isn't behaving for you
Lou — 13/02/2024 13:19
fyi https://trello.com/c/r0G32TiI/20-mm-19-fetch-apod-data-from-the-api is an example of making new sub tickets 🙂
Lou — 13/02/2024 13:41
I have just pushed some more changes, we now have a router and a basic landing page setup 🙂 a npm install will need to be run again when you fetch
Vicky — 13/02/2024 14:02
Hi Lou, hi Emily,  if any of you have time, could you jump to room2? Thank you
Lou — 13/02/2024 15:31
a good react testing website, halfway down it mentions how to mock an api to test 🙂 https://www.browserstack.com/guide/react-testing-tutorial
BrowserStack
React Testing: How to test React components? | BrowserStack
An in-depth tutorial for React testing using Jest, Enzyme, and Cypress and best practices for unit tests, integration tests, and E2E testing of React components.
React Testing: How to test React components? | BrowserStack
Emily — 14/02/2024 12:42
<main>
  <form>
    <label>
      Enter pokemon name:
      <br />
      <input type="text" />
    </label>
    <button type="submit">Get info!</button>
  </form>
  <div>
    <img src="" alt="Spheal" />
    <h1>Spheal</h1>
    <h2>Type(s): ice and water</h2>
    <p>Base experience: 75</p>
  </div>
</main>
Emily — 14/02/2024 12:53
import './App.css'

function App() {
  const pokemon = {
    name: "spheal",
    types: [
      "ice",
      "water",
    ],
    base_experience: 75,
    img_url: "",
  }

  return (
    <main>
      <form>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" />
        </label>
        <button type="submit">Get info!</button>
      </form>
      <div>
        <img src="" alt="Spheal" />
        <h1>{pokemon.name}</h1>
        <h2>Type(s): {pokemon.types.join(" and ")}</h2>
        <p>Base experience: {pokemon.base_experience}</p>
      </div>
    </main>
  )
}

export default App
Emily — 14/02/2024 13:00
import { useState } from 'react'
import './App.css'

function App() {
  const [pokemon, setPokemon] = useState({
    name: "spheal",
    types: [
      "ice",
      "water",
    ],
    base_experience: 75,
    img_url: "",
  })

  return (
    <main>
      <form>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" onChange={(event) => {
            setPokemon({...pokemon, name: event.target.value})
          }} />
        </label>
        <button type="submit">Get info!</button>
      </form>
      <div>
        <img src="" alt="Spheal" />
        <h1>{pokemon.name}</h1>
        <h2>Type(s): {pokemon.types.join(" and ")}</h2>
        <p>Base experience: {pokemon.base_experience}</p>
      </div>
    </main>
  )
}

export default App
Emily — 14/02/2024 13:08
import { useState } from 'react'
import './App.css'

interface Pokemon {
  name: string
  img_url: string
  types: string[]
  base_experience: number
}

function App() {
  const [pokemon, setPokemon] = useState<Pokemon>()

  return (
    <main>
      <form>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" />
        </label>
        <button type="submit">Get info!</button>
      </form>
      {pokemon &&
        <div>
          <img src="" alt="Spheal" />
          <h1>{pokemon.name}</h1>
          <h2>Type(s): {pokemon.types.join(" and ")}</h2>
          <p>Base experience: {pokemon.base_experience}</p>
        </div>
      }
      {!pokemon &&
        <p>Loading...</p>
      }
    </main>
  )
}

export default App
https://pokeapi.co/
PokéAPI
An open RESTful API for Pokémon data
Image
Emily — 14/02/2024 13:38
import { useState, useEffect } from 'react'
import './App.css'

interface Pokemon {
  name: string
  sprites: {
    front_default: string
  }
  types: {
    type: {
      name: string
    }
  }[]
  base_experience: number
}

function App() {
  const [pokemonName, setPokemonName] = useState<string>("")
  const [pokemon, setPokemon] = useState<Pokemon>()

  useEffect(() => {
    if (pokemonName) {
      fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`)
        .then((response) => response.json())
        .then(data => {
          setPokemon(data)
          console.log(pokemon)
        })
    }
  }, [pokemonName])

  return (
    <main>
      <form>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" value={pokemonName} onChange={(event) => setPokemonName(event.target.value)} />
        </label>
        {/* <button type="submit">Get info!</button> */}
      </form>
      {pokemon &&
        <div>
          <img src="" alt="Spheal" />
          <h1>{pokemon.name}</h1>
          <h2>Type(s): {pokemon.types.map((typeData) => typeData.type.name).join(" and ")}</h2>
          <p>Base experience: {pokemon.base_experience}</p>
        </div>
      }
      {!pokemon &&
        <p>Loading...</p>
      }
    </main>
  )
}

export default App
Emily — 14/02/2024 13:55
import { useState } from 'react'
import './App.css'

interface Pokemon {
  name: string
  sprites: {
    front_default: string
  }
  types: {
    type: {
      name: string
    }
  }[]
  base_experience: number
}

function App() {
  const [pokemon, setPokemon] = useState<Pokemon>()

  const handleSubmit: React.FormEventHandler<HTMLFormElement> = (event) => {
    event.preventDefault()
    const formData = new FormData(event.target as HTMLFormElement)
    const pokemonName = formData.get("pokemonName")
    if (pokemonName) {
      fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`)
        .then((response) => response.json())
        .then((data) => setPokemon(data))
    }
  }

  return (
    <main>
      <form onSubmit={handleSubmit}>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" name="pokemonName" />
        </label>
        <button type="submit">Get info!</button>
      </form>
      {pokemon &&
        <div>
          <img src={pokemon.sprites.front_default} alt={pokemon.name} />
          <h1>{pokemon.name}</h1>
          <h2>Type(s): {pokemon.types.map((typeData) => typeData.type.name).join(" and ")}</h2>
          <p>Base experience: {pokemon.base_experience}</p>
        </div>
      }
      {!pokemon &&
        <p>Loading...</p>
      }
    </main>
  )
}

export default App
 
Emily — 14/02/2024 14:03
import { useState } from 'react'
import './App.css'

interface Pokemon {
  name: string
  sprites: {
    front_default: string
  }
  types: {
    type: {
      name: string
    }
  }[]
  base_experience: number
}

function App() {
  const [pokemon, setPokemon] = useState<Pokemon>()
  const [loading, setLoading] = useState<boolean>(false)
  const [error, setError] = useState<boolean>(false)

  const handleSubmit: React.FormEventHandler<HTMLFormElement> = (event) => {
    event.preventDefault()
    setPokemon(undefined)
    setError(false)
    const formData = new FormData(event.target as HTMLFormElement)
    const pokemonName = formData.get("pokemonName")
    if (pokemonName) {
      setLoading(true)
      fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`)
        .then((response) => response.json())
        .then((data) => setPokemon(data))
        .catch(() => setError(true))
        .finally(() => setLoading(false))
    }
  }

  return (
    <main>
      <form onSubmit={handleSubmit}>
        <label>
          Enter pokemon name:
          <br />
          <input type="text" name="pokemonName" />
        </label>
        <button type="submit">Get info!</button>
      </form>
      {pokemon &&
        <div>
          <img src={pokemon.sprites.front_default} alt={pokemon.name} />
          <h1>{pokemon.name}</h1>
          <h2>Type(s): {pokemon.types.map((typeData) => typeData.type.name).join(" and ")}</h2>
          <p>Base experience: {pokemon.base_experience}</p>
        </div>
      }
      {loading &&
        <p>Loading...</p>
      }
      {error &&
        <p>Couldn't find your pokemon!</p>
      }
    </main>
  )
}

export default App
Marta — 14/02/2024 15:44
hello?
Emily — 16/02/2024 17:19
Relative positioning:

https://codepen.io/egrfly/pen/poYGKNa
https://codepen.io/egrfly/pen/bGZzKdg
CodePen
Emily F
Overlay
...
Overlay
CodePen
Emily F
CSS Positioning
...
CSS Positioning
Emily — 19/02/2024 10:07
https://techswitch.atlassian.net/wiki/spaces/0RC/pages/1644003329/11+-+FizzBuzz+C
Log in with Atlassian account
Log in to Jira, Confluence, and all other Atlassian Cloud products here. Not an Atlassian user? Sign up for free.
https://dotnet.microsoft.com/en-us/download
Microsoft
Download .NET (Linux, macOS, and Windows)
Free downloads for building and running .NET apps on Linux, macOS, and Windows. Runtimes, SDKs, and developer packs for .NET Framework, .NET, and ASP.NET.
Download .NET (Linux, macOS, and Windows)
Emily — 19/02/2024 10:17
https://docs.google.com/spreadsheets/d/1U9sSyX2WpqD_f-yhPpPDRAOW1VhlpCxEzN-KXqxGdqY
Emily — 19/02/2024 11:01
https://www.toptal.com/developers/gitignore/
gitignore.io
Create useful .gitignore files for your project
gitignore.io
Emily — 19/02/2024 12:42
If you manage to complete the stretch goals before I get back, try walking through the exercises in these slides: https://docs.google.com/presentation/d/1SQ-2hSCCuRPDbl-sC4VufQF6PR2Dbw_J-dUxe7J7PrE/ 😄
Emily — 20/02/2024 14:05
Let’s imagine that we want to build a program that manages all of the inventory in a shop.​

We’d like it to​
Know how many of each product we have in stock​
Allow a customer to add items to a basket (and then purchase all the items)​
Allow the manager to order new stock​
Produce a report of the stock and what got sold in the last week.​
 
Marta — 20/02/2024 14:19
I can hear you
but on the phone
Emily — Yesterday at 11:04
https://docs.google.com/presentation/d/1z5AKp1wWEYpd8JVPoz1PzH9-54IeBSj4Q317MzivE-g/edit?usp=sharing
Emily — Yesterday at 12:25
https://www.sporcle.com/games/egrfly/csharp-linq-ienumerable-extension-methods
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-8.0
Emily — Yesterday at 14:10
https://docs.google.com/presentation/d/1qZjZvLmOf3SpC6jKIEqVU7qQqOhIGo34yU6qDjlIBgQ/edit?usp=sharing
Emily — Yesterday at 15:36
var game = new Game();
var emily = new User
{
    Id = 1,
    Username = "emily1234",
    Password = "myExtremePassword",
Expand
Game.cs
3 KB
Emily — Today at 11:29
var broccoli = new Product
{
    Name = "broccoli",
    Price = 0.6m,
    Supplier = "Sheepy Farms",
};
Expand
Shop.cs
4 KB
Emily — Today at 11:52
var broccoli = new Product
{
    Name = "broccoli",
    Price = 0.6m,
    Supplier = "Sheepy Farms",
};
Expand
Shop.cs
5 KB
﻿
var broccoli = new Product
{
    Name = "broccoli",
    Price = 0.6m,
    Supplier = "Sheepy Farms",
};
var bananaSmoothie = new Product
{
    Name = "banana smoothie",
    Price = 3m,
    Supplier = "Innocent Smoothies"
};

var products = new List<Product>
{
    broccoli,
    bananaSmoothie,
};

var inventory = new Inventory();
inventory.Stock.Add(broccoli, 5);
inventory.Stock.Add(bananaSmoothie, 10);

void LookUpProduct()
{
    Console.WriteLine("Enter the name of the product you would like to find out more about:");
    var productName = Console.ReadLine() ?? "";
    var matchingProduct = products.First(product => product.Name == productName);
    Console.WriteLine($"Name: {matchingProduct.Name}");
    Console.WriteLine($"Price: {matchingProduct.Price}");
    Console.WriteLine($"Supplier: {matchingProduct.Supplier}");
    Console.WriteLine($"Stock: {inventory.Stock[matchingProduct]}");
}

void AddItemToBasket(Basket basket)
{
    Console.WriteLine("Enter the name of the product you would like to add to the basket:");
    var productName = Console.ReadLine() ?? "";
    var matchingProduct = products.First(product => product.Name == productName);
    var stock = inventory.Stock[matchingProduct];
    if (stock == 0)
    {
        Console.WriteLine("Sorry, that product is currently out of stock.");
    }
    else
    {
        basket.Products.Add(matchingProduct);
        inventory.Stock[matchingProduct]--;
        Console.WriteLine($"Success: {matchingProduct.Name} has been added to the basket.");
    }
}

Console.WriteLine("Are you a customer or an employee?");
if (Enum.TryParse<Role>(Console.ReadLine(), ignoreCase: true, out var role))
{
    if (role == Role.Employee)
    {
        Console.WriteLine("Welcome, employee.");
        Console.WriteLine("*****");
        Console.WriteLine("[1] Look up a product");
        Console.WriteLine("[2] Register new stock");
        Console.WriteLine("Enter the number of the action you would like to take:");
        if (int.TryParse(Console.ReadLine(), out var actionNumber))
        {
            if (actionNumber == 1)
            {
                LookUpProduct();
            }
            else if (actionNumber == 2)
            {
                Console.WriteLine("Sorry, we don't have a way of adding new stock yet.");
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't one of the options.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, I didn't understand your response.");
        }
    }
    else if (role == Role.Customer)
    {
        var basket = new Basket();
        Console.WriteLine("Welcome, customer. You have been given an empty basket.");
        while (true)
        {
            Console.WriteLine("*****");
            Console.WriteLine("[1] Add an item to the basket");
            Console.WriteLine("[2] Check out");
            Console.WriteLine("Enter the number of the action you would like to take next:");
            if (int.TryParse(Console.ReadLine(), out var actionNumber))
            {
                if (actionNumber == 1)
                {
                    AddItemToBasket(basket);
                    continue;
                }
                else if (actionNumber == 2)
                {
                    Console.WriteLine("Sorry, we don't have a way of checking out yet.");
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't one of the options.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand your response.");
            }
            break;
        }
    }
}
else
{
    Console.WriteLine("Sorry, I didn't understand your response.");
}

class Inventory
{
    public Dictionary<Product, int> Stock { get; } = new Dictionary<Product, int>();
}

class Product
{
    public required string Name { get; init; }
    public required decimal Price { get; init; }
    public required string Supplier { get; init; }
}

class Basket
{
    public List<Product> Products { get; } = new List<Product>();
}

enum Role
{
    Customer,
    Employee,
}
Shop.cs
5 KB