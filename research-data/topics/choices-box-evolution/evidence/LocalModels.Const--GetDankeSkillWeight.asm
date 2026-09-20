; LocalModels.Const$$GetDankeSkillWeight
; RVA 0x64CB688; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CB688  str      x30, [sp, #-0x20]!
0064CB68C  stp      x20, x19, [sp, #0x10]
0064CB690  adrp     x19, #0x9597000
0064CB694  adrp     x20, #0x8efa000
0064CB698  ldrb     w8, [x19, #0xfdf]
0064CB69C  ldr      x20, [x20, #0x128] ; GLOBAL Method$LocalModels.Const.GetDankeSkillWeight() @ 0x9255ef0
0064CB6A0  tbnz     w8, #0, #0x64cb6c4
0064CB6A4  adrp     x0, #0x8efa000
0064CB6A8  ldr      x0, [x0, #0x128] ; GLOBAL Method$LocalModels.Const.GetDankeSkillWeight() @ 0x9255ef0
0064CB6AC  bl       #0x382bd14 ; 
0064CB6B0  adrp     x0, #0x8ee8000
0064CB6B4  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064CB6B8  bl       #0x382bd14 ; 
0064CB6BC  mov      w8, #1
0064CB6C0  strb     w8, [x19, #0xfdf]
0064CB6C4  ldr      x0, [x20]
0064CB6C8  ldrb     w8, [x0, #0x53]
0064CB6CC  tbnz     w8, #5, #0x64cb6f8
0064CB6D0  adrp     x19, #0x8ee8000
0064CB6D4  ldr      x19, [x19, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064CB6D8  ldr      x0, [x19]
0064CB6DC  ldr      w8, [x0, #0xe0]
0064CB6E0  cbz      w8, #0x64cb708
0064CB6E4  ldr      x8, [x0, #0xb8]
0064CB6E8  ldrb     w9, [x8, #0x530]
0064CB6EC  cbz      w9, #0x64cb724
0064CB6F0  ldr      x0, [x8, #0x4d0]
0064CB6F4  b        #0x64cb728 ; 
0064CB6F8  ldr      x1, [x0, #0x60]
0064CB6FC  ldp      x20, x19, [sp, #0x10]
0064CB700  ldr      x30, [sp], #0x20
0064CB704  br       x1
0064CB708  bl       #0x382be8c ; 
0064CB70C  ldr      x0, [x19]
0064CB710  ldr      x8, [x0, #0xb8]
0064CB714  ldr      w9, [x0, #0xe0]
0064CB718  ldrb     w20, [x8, #0x530]
0064CB71C  cbz      w9, #0x64cb734
0064CB720  cbnz     w20, #0x64cb6f0
0064CB724  ldr      x0, [x8, #0x4c8]
0064CB728  ldp      x20, x19, [sp, #0x10]
0064CB72C  ldr      x30, [sp], #0x20
0064CB730  ret      
0064CB734  bl       #0x382be8c ; 
0064CB738  ldr      x8, [x19]
0064CB73C  ldr      x8, [x8, #0xb8]
0064CB740  cbnz     w20, #0x64cb6f0
0064CB744  b        #0x64cb724 ; 

