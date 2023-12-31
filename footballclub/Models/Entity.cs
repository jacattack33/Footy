﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using Microsoft.CodeAnalysis;

namespace footballclub.Models
{
    public class Entity
    {
        //I'm not sure if we NEED an I.D. field for each entity, but I made one just in case.
        public Guid Id { get; set; }
        //static private int nextId = 1;

        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(string name, string city, string state, string description, string type) : this()
        {
            Id = Guid.NewGuid();
            Name = name;
            City = city;
            State = state;
            Description = description;
            Type = type;
        }

        public override string ToString()
        {
            string output = "";

            output = string.Format("\nName: %d\n" +
                "City: %s\n" +
                "State: %s\n" +
                "Description: %s\n" +
                "Type: %s\n", Name, City, State, Description, Type);

            return output;
        }
    }
}