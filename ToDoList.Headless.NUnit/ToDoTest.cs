using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Headless.NUnit;
using Avalonia.Input;
using NUnit.Framework;
using ToDoList.DataModel;
using ToDoList.ViewModels;
using ToDoList.Views;

namespace ToDoList.Headless.NUnit;

public class ToDoTest
{
    [AvaloniaTest]
    public void List_Add_Item()
    {
        var window = new MainWindow {
            DataContext = new MainWindowViewModel()
        };
        window.Show();

        var contentView = (ToDoListViewModel)window.Content;
        Assert.IsNotNull(contentView);
        
        // TODO: - Revisar error de acceso a myButton
        // Button myButton = contentView.FindControl<Button>("AddItem");
    }
}