# LearningASP

In that project, I'm trying to learn how to use the ASP.NET based on MVC (Model-View-Controller)

**Documentation link:** [ASP Documentation](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio)

**TABLE OF CONTENTS**
* [**Controllers**](#1-controllers)
* [**Views**](#2-views)
* [**Models**](#3-models)

## **1. Controllers**
Controllers are classes that:
- Handle browser requests.
- Retrieve model data.
- Call view templates that return a response.

### **Create a controller**
To create a controller, right click on the "Controllers" folder, "Add" then "Controller". <br>
You'll get a basic controller with an Index() method.
<br>

Index() is called when you access the base URL of the page. 
<br> *For instance : Your created a "Chapter" controller, you can access it by going to localhost:{Port}/Chapter. When you are here, Index() will be executed by default.*

### **Setting multiple routes**
If you want to manage more complexe request, you'll need to create other methods and access it by changing the current route. Let's define a few methods:

Here is a simple method to show a string depending of given arguments like a name or an id.
```bash 
// GET: /Chapter/WelcomeWithId/6?name=YourName
// Where '6' is the id added as an argument
public string WelcomeWithId(string name, int id)
{
    return HtmlEncoder.Default.Encode(
        $"Hello {name}, your user id is: {id}"
    );
}
```
That's how you define a custom "Get" route. But that's pretty annoying, you should use a [View](#2-views) to render something more interesting!
```bash
// GET: /Chapter/Welcome?name=YourName&rank=YourRank
public IActionResult Welcome(string name, string rank)
{
    @ViewData["Name"] = HtmlEncoder.Default.Encode(name);
    @ViewData["Rank"] = HtmlEncoder.Default.Encode(rank);
    return View();
}
```
In the above code, we call a View method. By doing so, we request a view script to render our result. But not any View, we need to create a custom view with a similar name to our function, in our case "Welcome.cshtml".
<br>
What's interesting is that we can save variables and transfer them to a view by use `@ViewData["DataName"]`.

## **2. Views**
Views are the components that display the app's user interface (UI). Generally, this UI displays the model data.

## **3. Models**
Classes that represent the data of the app. Model objects retrieve and store model state in a database.