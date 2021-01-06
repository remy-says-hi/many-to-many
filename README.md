Hello Epicodus Student!

This repo has an example of one join table that tracks two many-to-many relationships. In the models folder you will find the join table `CategoryItemTag`, which tracks a many-to-many relationship between Categories and Items, and a many-to-many relationship between Items and Tags. There is no relationship between Categories and Tags. 

Nullable Types are important to make it possible to track multiple relationships in one join table. You'll notice the `?` next two `CategoryId` and `TagId` in the `CategoryItemTag` model. Nullable means that the value can be `null`. It's important to specify that these two properties are nullable, so that with Code-First Migrations, Entity knows to set up the database columns as nullable as well.

Here's an example of what the CategoryItemTags table might look like:
```
CategoryItemtagId   CategoryId    ItemId    TagId
      1                 2            1       null
      2                null          1        3
```      

You'll notice that all files in the models folder have been adjusted to show you how to set this up, and that the Categories and Items Controller have been updated to work with Tags. The migrations folder is also up to date.

**Please note, I have purposefully left out the TagsController and Views so that you get practice putting that together. You already have all the skills to do so.**