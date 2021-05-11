# FlowAccount Challenges (The Pouch Application)

### 1. Introduction
Pouch is an personal expenses tracking application with an intuitive UI showing all transactions as a list of card view.

## iOS

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

### Work Process
1. Fork this repository to start your challenge.
2. Create a pull request when your work is done.
3. Keep the comment conversation alive.

### Resources
[Transaction Detail Assets](https://drive.google.com/drive/folders/1hSuAjr5-MCaIGDt0JB9fPmkTv4XkV66x)
