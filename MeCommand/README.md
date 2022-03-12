# MeCommand
A sample program showing how I use binding to command in WPF.

I'm using Community Toolkit MVVM and RelayCommand.

The sample consist of two textboxes and three buttons.
![MainWindow](file:///C:/Users/Anders/Source/Repos/Temp/MeCommand/Images/mainwindow.png)

The textboxes are bound to a property in MainViewModel

| Textbox      | Property |
|--------------|----------|
| NameTextbox1 | Name1    |
| NameTextbox2 | Name2    |


## Button1
The *Button1* will update the the property *Name1* with a text. It switches between  "Uriah Heep" and "Deep Purple" each time you click the button.

## Button2
*Button2* does the same thing as *Button1*, but if there isn't any text in *NameTextbox1* the button will be disabled.

## Button3
*Button3* is enabled when *NameTextbox1* has some text and will copy the text from *NameTextbox1* to *NameTextbox2*. I'm using **CommandParameter** to send the *NameTextbox1* text to *Button3Command*
