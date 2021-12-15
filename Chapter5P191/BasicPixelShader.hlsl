#include "BasicShaderHeader.hlsli"
Texture2D<float4> tex : register(t0); // 0 番スロットに設定されたテクスチャ
SamplerState smp : register(s0);      // 0 番スロットに設定されたサンプラー


float4 BasicPS(Output input) : SV_TARGET{

	return float4(tex.Sample(smp,input.uv));
	//return float4(1,1,1,1);
}