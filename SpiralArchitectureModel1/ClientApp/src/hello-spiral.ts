// ClientApp/src/hello-spiral.ts

// C#の構造と同期させたインターフェース
interface PriceData {
    basePrice: number;
    totalPrice: number;
    generatedAt: string;
}

export const initHelloSpiral = (data: PriceData) => {
    const app = document.getElementById("spiral-app");
    
    if (app) {
        app.innerHTML = `
            <div style="border: 2px solid #2563eb; padding: 20px; border-radius: 10px;">
                <h3 style="color: #2563eb;">Spiral Architecture Demo</h3>
                <p>元の価格: ￥${data.basePrice.toLocaleString()}</p>
                <p><strong>税込価格 (C#計算): ￥${data.totalPrice.toLocaleString()}</strong></p>
                <small style="color: #64748b;">生成時刻: ${data.generatedAt}</small>
            </div>
        `;
        console.log("GUI Rendered by TypeScript with C# Data.");
    }
};