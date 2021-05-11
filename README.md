
# FlowAccount Challenges (The Pouch Application)

### 1. Introduction
Pouch is an personal expenses tracking application with an intuitive UI showing all transactions as a list of card view.

## Typescript Node

## Typescript Angular

There is already a create update component in the frontend app. We already have the beautiful html/css for you as well. What do you need to do?

- Use form builder to validate the form
- Save and update the form with our provided API

We will test you on:

1. Clean code
2. Understanding of angular mechanism
3. rxjs implementation (@ngrx/store)
4. TDD
5. Defensive coding

## Aws-CDK

For the infrastructure we have the ready part for transaction that is working now.
What we would like you to do is create a new stack to deploy to the same cluster for a wallet service.
The hello world code for wallet service can be found here -->

## Dotnet (C#)

For this part, we want you to design how to store category data in a relational-database
We provide you a base where there is a working transaction api.

The requirements are here:

1. There will be a category menu where it can perform Create/Update/Delete actions on the categories.
2. The categories will be separated in two types.Income and Expense.
3. The categories will have
    - an input field
    - a type
4. If a category has a transaction tied to it already
   - that category type cannot be changed.
   - that category cannot be deleted.

What is the output we are looking for:

1. ER Diagram
2. Sequence Diagram (Optional)
3. Postman integration test

What we evaluate you on:

1. Clean code
2. TDD
3. Defensive coding
4. OOP
5. DB Design

## iOS

## Android (Transaction CRUD)

### 1. What you'll build
In this exam, you'll build some new features from existing project.
Requirements:
 - create new transaction page.
 - edit transaction page.

### 2. What are we concern
- separation of concerns
- android architecture component
- material design
- test driven development
- design pattern
- defensive programming
- algorithm

### 3. Requirement
create new transaction screen design.

![Screen Shot 2564-03-23 at 16 03 28](https://user-images.githubusercontent.com/60771871/112121279-a82f8d80-8bf1-11eb-914e-1b7a13e63b7a.png)

### Create Transaction screen will has the following requirements
1. User can add an amount.
2. User has to do nothing with label
3. User can select his transaction type (spinner).
4. User can select his transaction category (category spinner shows all existing category from the transaction list).
5. If user want to create new category, then he can manually type his new category by just clicking the category name (click the down arrow will show all categories in the spinner).
6. User can select his transaction date (calendar view).
7. User can manually add his own transaction note.
8. Transaction amount is a require field and must be only number.
9. Transaction category is a require field.
10. Transaction note is an optional field with maximum 100 characters length.
11. The validation will be triggered interactively with user's input.
12. After successfully created new transaction, application must save the transaction into app's database (sqlite) and navigate back to transaction list screen.

### Bonus
1. There's some mistakes in the code structure and we will be pleasured if you can correct them.

## Android (Categories Tree Count)
The categoris for transactions (income/expense) are multilevel categories
example:

```
├── Entertainment
                 ├── Office Dinner
                 ├── Client Meeting
                 ├── Team activies
                                  ├── Movies
                                  ├── After work party
                                                     ├── (n*x)
```                                                  

The callenge is:
1. Define a model for this unlimited level of categories in the front-end
2. Write an algorithm to count the number of all the parents and childrent categories using `Entertainment` tree as your mock data

Output: 
1. Model that works
2. Function that show the `TOTAL` count of the categories
3. Test Driven Design
4. Clean and understandable code

### Work Process
1. Fork this repository to start your challenge.
2. Create a pull request when your work is done.
3. Keep the comment conversation alive.

### Resources
[Transaction Detail Assets](https://drive.google.com/drive/folders/1hSuAjr5-MCaIGDt0JB9fPmkTv4XkV66x)
