
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double valor1;

        [ObservableProperty]
        private double valor2;

        [ObservableProperty] 
        private double resultado;

        [RelayCommand]
        private void Suma()
        {
           Resultado = Valor1 + Valor2;
        }

        [RelayCommand]
        private void Limpiar()
        {
            Valor1 = Valor2 = Resultado = 0;
        }

    }
    

    
    
    
}
