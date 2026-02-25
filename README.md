## Important Note Regarding Submission Timing

Unfortunately, I was not able to complete and commit the fully working version of this project before the official deadline.

The final working version was committed **after the deadline**, and I completely understand if this is considered a violation of the submission rules. If so, please feel free to **ignore this repository and not waste time reviewing it**, I sincerely apologize for that.

I still decided to push my final implementation for transparency and learning purposes.

Additionally, **not all features are working as expected yet**.

Thank you very much for your time and consideration.

# Contact Indexing System

A contact management app that stores and finds contacts quickly using hash-based indexing. Built with C# and .NET 9.0.

## How to Run the App

### What You Need
- .NET 9.0 SDK

### Steps to Run

1. Open PowerShell and go to the project folder:
   ```powershell
   cd Microsoft-Summer-Internship-task---Contact-Indexing-System/CIS
   ```

2. Build the project:
   ```powershell
   dotnet build
   ```

3. Run the app:
   ```powershell
   dotnet run --project CIS/CIS.csproj
   ```

### Using the App

When you run it, you'll see this menu:

```
=== Contact Manager ===
1. Add Contact
2. Remove Contact
3. Update Contact
4. View Contact
5. List All Contacts
6. Search Contact
7. Save Contacts
0. Exit
```

Just pick a number to do what you want! For example:
- Press `1` to add a new contact
- Press `6` to search for someone
- Press `7` to save everything to a file
- Press `0` to quit



## Time Complexity

| Operation   | Complexity | Explanation                               |
| ----------- | ---------- | ----------------------------------------- |
| Add Contact | **O(1)**   | Add to linked list + update 4 hash tables |
| Search      | **O(1)**   | Direct hash lookup                        |
| Remove      | **O(1)**   | Node references allow direct removal      |
| Update      | **O(1)**   | Search + assign new value                 |
| List All    | **O(n)**   | Must iterate all contacts                 |
| Save        | **O(n)**   | Serialize entire list                     |


### Why is searching so fast?

I use 4 separate hash tables (one for each field):
- Name -> quickly find contacts by name
- Phone -> quickly find contacts by phone
- Email -> quickly find contacts by email  
- ID -> quickly find contacts by ID

So instead of checking every contact, we just look it up in the hash table instantly!

### Why is removing so fast?

Because:
- Each index stores LinkedListNode<Contact>
- We delete directly using node references
- No searching required