# Assignment3
Repository for Assignment 3

75 points

For this assignment, you will need to start with this tabs app starter project and create an MvvM extravaganza.
Not really, but it needs to be a tabbed MvvM app.  You can repurpose the ViewModel classes if you wish but
their names should match at least somewhat the content of the page and they need to be MvxViewModel derivatives.
As I'm sure you guessed, you will need to convert this standard Xamarin app into MvvM using MvvMCross
You should have 2 screens - the primary one which actually should be an "About" page
This should consider this page to be a profile page, as if this mobile app was your resume, so 
it can be a combination of free form text wtih a heading, a list of accomplishments, you can have images, links, etc.
The main page just needs to behave like a profile screen.
The data that appears on this screen needs to be bound to the view model.  You can use strings for the text, image sources, etc.
For lists you can use List<T>  or ObservableCollections.  The data should be supplied to the VM from a service which is injectable as an
interface into the view model.  The data can be totally static, but must be provided by a service.

The second page should be a web page.  It can be whatever you like (obviously no porn or explicit content).  It can be a web page you
made yourself (a few extra credit points if it is), or it can be a website you like that could be related to a topic you feel strongly about, or pretty much anything taht does not require a membership or a sign in to access.  The page source for this also needs to be bound to a view model.  You do not need a service for this page, just a bindable property for the page source.

Have fun with it!
