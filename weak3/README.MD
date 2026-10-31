# C# Windows Forms: Chapter 3 - Making Decisions

## 📖 Overview
This repository contains practical applications, lab assignments, and code examples for **Chapter 3: Making Decisions** (based on *Starting Out with Visual C#*)[cite: 8]. This chapter covers essential programming logic that enables applications to evaluate conditions, validate user inputs, manage UI controls, and dynamically control execution paths.

---

This chapter explains how to make decisions in C# programming. Decision structures allow a program to choose what action to perform depending on whether a condition is true or false.
 Decision Structures and the if Statement

A decision structure allows a program to execute statements depending on a condition.

## 🚀 Key Topics & Concepts Covered

1. **Decision Structures & The `if` Statement**
   - Implementing single-alternative selection paths using relational operators (`>`, `<`, `>=`, `<=`, `==`, `!=`).
2. **The `if-else` Statement**
   - Executing alternative blocks of code based on whether a Boolean expression evaluates to `true` or `false`
3. **Nested Decision Structures & `if-else-if` Statements**[cite: 8]
   - Handling multi-alternative conditions for complex business logic (e.g., academic grading systems, loan qualification checks)
4. **Logical Operators**
   - Combining expressions using **AND (`&&`)**, **OR (`||`)**, and negating values using **NOT (`!`)**
5. **Boolean Variables and Flags**
   - Using `bool` variables to track states and signal when specific conditions exist in the program.
6. **Comparing Strings**
   - Safely comparing text values using relational operators and built-in methods like `String.Compare` and `CompareTo`[cite: 8].
7. **Preventing Data Conversion Exceptions (`TryParse`)**[cite: 8]
   - Utilizing `int.TryParse`, `double.TryParse`, and decimal parsing with the `out` keyword to prevent application crashes caused by invalid user inputs.
8. **Input Validation**
   - Inspecting data integrity to ensure entered numbers fall within valid business logic ranges before performing calculations.
9. **Radio Buttons and Check Boxes**[cite: 8]
   - Managing mutually exclusive choices (Radio Buttons) and multiple options (Check Boxes) using the `Checked` property and event handlers[cite: 8].
10. **The `switch` Statement**[cite: 8]
    - Creating cleaner multi-alternative decision structures as an alternative to long `if-else-if` chains using `case`, `break`, and `default`
11. **Introduction to List Boxes**[cite: 8]
    - Populating, reading, and modifying items inside `ListBox` controls using properties and methods such as `Items.Add`, `SelectedItem`, `SelectedIndex`, `Items.RemoveAt`, and `Items.Clear`[cite: 8].

---

## 🛠️ Code Implementation Highlights

### 1. Safe Input Validation (`TryParse`)
```csharp
int score;
if (int.TryParse(txtScore.Text, out score))
{
    // Valid input processing
}
else
{
    MessageBox.Show("Please enter a valid numeric value.");
}if (listBox1.SelectedIndex != -1)
{
    string selectedCourse = listBox1.SelectedItem.ToString();
    MessageBox.Show("Selected item: " + selectedCourse);
}