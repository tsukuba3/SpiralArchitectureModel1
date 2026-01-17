// Models/PriceCalculatorViewModel.cs
namespace SpiralArch.Models
{
    public class PriceCalculatorViewModel
    {
        public int BasePrice { get; set; } = 1000;
        
        // GUIから分離された「純粋なアルゴリズム」
        // 税率変更時もここを直すだけで、全ての画面に適用される
        public double GetTaxIncluded() => BasePrice * 1.1;

        // TypeScriptに渡すためのJSONライクな構造
        public object ToJson() => new {
            basePrice = BasePrice,
            totalPrice = GetTaxIncluded(),
            generatedAt = System.DateTime.Now.ToString("HH:mm:ss")
        };
    }
}