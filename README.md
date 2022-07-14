# Asynchronization-and-processes-in-C#-

Background:

Intro:

This is a C# console application displaying various techniques asynchronzation, opening, closing and sending information to processes.

Please see attached screenshots for further understanding.

This program has two main features:

#1 being the opening of files. In this case as a user runs the app, it will open notepad.exe, which can be changed for other applications.
Then if the user types in 'k' and enter, it will kill (close) this process.

If the user types in 'f', it will create a new textfile, and write 2 sentences to it. In an update I want it to open the edited text file on run.

And #2 being the displayed list of running processes on the current computer and their associated IDs, showed on the console. This is displayed after the user clicks the enter button on the console. This is like a C# console task manager as processes and IDs are displayed and we can set input or usecases where we can instantly kill these running processes.

/Asynchronization-and-processes-in-C#


Please note part of the destination has been replaced with '-----'. If you would like to run this program, please replace it with your username, as I don't want to potentially dox myself.

![codebehind_async](https://user-images.githubusercontent.com/101861214/178963010-e9027a08-534c-4663-a48a-b0d1a87ecb20.png)


The current running processes: 

![Processes](https://user-images.githubusercontent.com/101861214/178963232-d6aa70a0-0936-4559-bc06-2a1a12b15588.png)


How it looks when written to a textfile:
![workingtxt](https://user-images.githubusercontent.com/101861214/178963318-d288fc15-a7e9-44d9-a70c-77089014527c.png)


The source code:

![sourcecode_async](https://user-images.githubusercontent.com/101861214/178963711-fc37465c-f280-406e-8d28-46e210668a04.png)

![sourcecode_async_2](https://user-images.githubusercontent.com/101861214/178963727-0c945121-e0d2-44cd-8bd3-901643ea0d57.png)


