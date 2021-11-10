#include "BasicShaderHeader.hlsli"

float4 BasicPS(Output input) : SV_TARGET{
	//return float4(0.5f+input.pos.x,sin(input.pos.y*20),1,1);
	return float4(input.uv, 1, 1);
	//float dx = abs(input.uv.x - 0.5f);
	//float dy = abs(input.uv.y - 0.5f);
	//float d = step(0.25f, sqrt(dx * dx + dy * dy));
	//return float4(1,d , d , 1);

}