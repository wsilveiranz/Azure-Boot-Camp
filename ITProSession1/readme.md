# IT Pro Session 1

There are several options for hands on labs for IT Pro session 1.  I wanted to make this as valuable as possible, and to cater for different skill levels. For all of the hands on labs you'll need access to an Azure subscription, trial or otherwise. If you're using a subscription that you already had, be aware that the Enterprise Ready Cloud will make changes to your subscription that will restrict your ability to do things - don't worry, it's reversible.

If you're coming in new to Azure IaaS, then the [Beginner lab](https://github.com/Microsoft/TechnicalCommunityContent/tree/master/Cloud%20Computing/Azure%20IaaS/Session%202%20-%20Hands%20On) is for you.  This takes you throught the basics of getting a Linux virtual machine set up with node.js and accessible via the web.

If you're an experienced Azure user, then there are three options you could choose.
1. Enterprise Ready Cloud
    This lab takes you through how you might provide control over an Azure environment for an Enterprise, applying policy and tags to resources, and using role based access and Dev/Test labs to provide a great developer experience.  See the warning above about the changes that this lab will make to your subscription - don't use a production subscription for this!
2. Enterprise Class Networking
    This lab walks you through some of the ways you can bypass Azure's default routing, implement a 3rd party firewall solution, and use Azure's load balancers.
3. Building a resilient IaaS infrastructure
    This lab takes you from an environment that has been implemented without the level of recommended resilience through to one that provides resilience.  This lab has a reasonably long set of pre-requisites to set up, so if you haven't set these up before the day of the bootcamp, I'd avoid this one.  You also likely won't complete the lab in the alloted time.


For all the labs you should have [Azure PowerShell](https://docs.microsoft.com/en-us/powershell/azure/install-azurerm-ps?view=azurermps-3.8.0) installed beforehand. It only takes a few minutes to install.