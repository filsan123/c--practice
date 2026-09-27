.explanation  for screenshots
Data Entry and Processing Application
Variable Declaration and Data Assignment
This section handles reading and processing information entered by the user. It declares string variables to store general text and integer variables to store whole numbers. The text entered into input fields is read directly, while numeric values are converted from text into actual numbers using parsing functions. All the retrieved values are then combined together into a single string using concatenation so the complete result can be shown on the screen.

Reset / Clear Action
This section handles resetting the form. It calls the clearing method on every input field to remove all existing text and sets the output display label back to an empty state. This effectively wipes out all previously entered data and prepares the screen for new input.

Application Exit Action
This section manages closing the application. It calls the close method on the current window, which safely terminates the running program and closes the user interface.