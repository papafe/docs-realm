﻿using System;
using System.Collections.Generic;
using System.Linq;
using Examples;
using MongoDB.Bson;
using Realms;

namespace Examples.Models
{
    // :snippet-start: embedded
    // :replace-start: {
    //  "terms": {
    //      "Address10": "Address",
    //       "Contact10": "Contact"}
    // }
    public partial class Address10 : IEmbeddedObject
    {
        public ObjectId Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
    public partial class Contact10 : IRealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public Address10 Address { get; set; } // embed a single address 
    }
    // :replace-end:
    // :snippet-end:


    // STAND-ALONE class; not used elsewhere
    // :snippet-start: primary-key
    // :replace-start: {
    //  "terms": {
    //      "Person_Required": "Person",
    //      "Doge": "Dog",
    //      "//[NotPrimaryKey]": "[PrimaryKey]" }
    // }
    public partial class Doge : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        //[NotPrimaryKey]
        public string Name { get; set; }
        public int Age { get; set; }
        public Person_Required Owner { get; set; }
    }
    //:replace-end:
    // :snippet-end:

    // :snippet-start: required
    // :replace-start: {
    //  "terms": {
    //      "Person_Required": "Person",
    //      "Dog_OMAS": "Dog"}
    // }
    public partial class Person_Required : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        [Required]
        public string Name { get; set; }
        public IList<Dog_OMAS> Dogs { get; }
    }
    //:replace-end:
    // :snippet-end:

    // :snippet-start: default
    // :replace-start: {
    //  "terms": {
    //      "PersonB": "Person" }
    // }
    public partial class PersonB : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        public string Name { get; set; } = "foo";
    }
    // :replace-end:
    // :snippet-end:

    // :snippet-start: index
    // :replace-start: {
    //  "terms": {
    //      "Person_Index": "Person",
    //      "Dog_OMAS": "Dog"}
    // }
    public partial class Person_Index : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        [Indexed]
        public string Name { get; set; }
        public IList<Dog_OMAS> Dogs { get; }
    }
    // :replace-end:
    // :snippet-end:

    // :snippet-start: rel-to-one
    // :replace-start: {
    //     "terms": {
    //      "Person_Rel_One_to_One": "Person",
    //      "Dog_Rel_One_to_One": "Dog" }
    // }
    public partial class Dog_Rel_One_to_One : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // ... other property declarations
        public Person_Rel_One_to_One Owner { get; set; }
    }

    public partial class Person_Rel_One_to_One : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // ... other property declarations
        public string Name { get; set; }
    }
    // :replace-end:
    // :snippet-end:

    // :snippet-start: rel-to-many
    // :replace-start: {
    //  "terms": {
    //   "Person_Rel_One_to_Many": "Person",
    //   "Dog_Rel_One_to_Many" : "Dog" }
    // }
    public partial class Dog_Rel_One_to_Many : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // ... other property declarations
        public string Name { get; set; }
    }

    public partial class Person_Rel_One_to_Many : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // ... other property declarations
        public IList<Dog_Rel_One_to_Many> Dogs { get; }
    }
    // :replace-end:
    // :snippet-end:


    partial class Dog_Inverse : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // To-one relationship from the Dog to its owner
        public Person_Inverse Owner { get; set; }
    }

    partial class Person_Inverse : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // An inverse relationship that returns all Dog instances that have Dog.Owner set to
        // the current Person.
        [Backlink(nameof(Dog_Inverse.Owner))]
        public IQueryable<Dog_Inverse> Dogs { get; }

        // To-many relationship, containing a collection of all hobbies the current person enjoys
        public IList<Hobby> Hobbies { get; }
    }

    partial class Hobby : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        // An inverse relationship that returns all Person instances that have the current Hobby
        // instance in their Hobbies list.
        [Backlink(nameof(Person_Inverse.Hobbies))]
        public IQueryable<Person_Inverse> PeopleWithThatHobby { get; }
    }

    class IgnorantRenamer
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        // :snippet-start: ignore
        // Rather than store an Image in Realm,
        // store the path to the Image...
        public string ThumbnailPath { get; set; }

        // ...and the Image itself can be
        // in-memory when the app is running:
        [Ignored]
        public Image Thumbnail { get; set; }
        // :snippet-end:
    }
    // :snippet-start: rename
    // :replace-start: {
    // "terms": {
    //   "PersonH": "Person"}
    // }
    public partial class PersonH : IRealmObject
    {
        //:remove-start:
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId ID { get; set; }
        //:remove-end:
        [MapTo("moniker")]
        public string Name { get; set; }
    }
    // :replace-end:
    // :snippet-end:

    public class Image
    {
    }
}

public partial class CustomGetterSetter : IRealmObject
{
    [PrimaryKey]
    public string _id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
    // :snippet-start: custom-setter
    // This property will be stored in the Realm
    private string email { get; set; }

    // Custom validation of the email property.
    // This property is *not* stored in Realm.
    public string Email
    {
        get { return email; }
        set
        {
            if (!value.Contains("@")) throw new Exception("Invalid email address");
            email = value;
        }
    }
    // :snippet-end:
}

// :snippet-start: rename-class
// :replace-start: {
// "terms": {
//   "PersonI": "Person",
//      "DogB": "Dog"}
// }
[MapTo("Human")]
public partial class PersonI : IRealmObject
{
    //:remove-start:
    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId ID { get; set; }
    //:remove-end:
    public string Name { get; set; }
}
// :replace-end:
// :snippet-end:

// :snippet-start: subset
// :replace-start: {
// "terms": {
//      "Dog_OMAS": "Dog"}
// }
// Declare your schema
partial class LoneClass : IRealmObject
{
    //:remove-start:
    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId ID { get; set; }
    //:remove-end:
    public string Name { get; set; }
}

class AnotherClass
{
    private void SetUpMyRealmConfig()
    {
        // Define your config with a single class
        var config = new RealmConfiguration("RealmWithOneClass.realm");
        config.Schema = new[] { typeof(LoneClass) };

        // Or, specify multiple classes to use in the Realm
        config.Schema = new[] { typeof(Dog_OMAS), typeof(Cat) };
    }
}
// :replace-end:
// :snippet-end:

class Cat
{ }
