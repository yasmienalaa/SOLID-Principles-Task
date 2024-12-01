using System;
using SOLID_CSharp;

var subscriptionManager = new SubscriptionManager();
        
// Create different subscription types
subscriptionManager.CreateSubscription("john@example.com", "Basic"); 
subscriptionManager.CreateSubscription("jane@example.com", "Pro");
        
// Process features
subscriptionManager.ProcessFeatures("john@example.com");
