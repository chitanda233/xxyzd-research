; LocalModels.Const$$GetPunchboardRandomSkillCountWeight
; RVA 0x64CB808; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064CB808  str      x30, [sp, #-0x20]!
0064CB80C  stp      x20, x19, [sp, #0x10]
0064CB810  adrp     x19, #0x9597000
0064CB814  adrp     x20, #0x8efa000
0064CB818  ldrb     w8, [x19, #0xfe1]
0064CB81C  ldr      x20, [x20, #0x138] ; GLOBAL Method$LocalModels.Const.GetPunchboardRandomSkillCountWeight() @ 0x9255f08
0064CB820  tbnz     w8, #0, #0x64cb844
0064CB824  adrp     x0, #0x8efa000
0064CB828  ldr      x0, [x0, #0x138] ; GLOBAL Method$LocalModels.Const.GetPunchboardRandomSkillCountWeight() @ 0x9255f08
0064CB82C  bl       #0x382bd14 ; 
0064CB830  adrp     x0, #0x8ee8000
0064CB834  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064CB838  bl       #0x382bd14 ; 
0064CB83C  mov      w8, #1
0064CB840  strb     w8, [x19, #0xfe1]
0064CB844  ldr      x0, [x20]
0064CB848  ldrb     w8, [x0, #0x53]
0064CB84C  tbnz     w8, #5, #0x64cb878
0064CB850  adrp     x19, #0x8ee8000
0064CB854  ldr      x19, [x19, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0064CB858  ldr      x0, [x19]
0064CB85C  ldr      w8, [x0, #0xe0]
0064CB860  cbz      w8, #0x64cb888
0064CB864  ldr      x8, [x0, #0xb8]
0064CB868  ldrb     w9, [x8, #0x530]
0064CB86C  cbz      w9, #0x64cb8a4
0064CB870  ldr      x0, [x8, #0x4f0]
0064CB874  b        #0x64cb8a8 ; 
0064CB878  ldr      x1, [x0, #0x60]
0064CB87C  ldp      x20, x19, [sp, #0x10]
0064CB880  ldr      x30, [sp], #0x20
0064CB884  br       x1
0064CB888  bl       #0x382be8c ; 
0064CB88C  ldr      x0, [x19]
0064CB890  ldr      x8, [x0, #0xb8]
0064CB894  ldr      w9, [x0, #0xe0]
0064CB898  ldrb     w20, [x8, #0x530]
0064CB89C  cbz      w9, #0x64cb8b4
0064CB8A0  cbnz     w20, #0x64cb870
0064CB8A4  ldr      x0, [x8, #0x4e8]
0064CB8A8  ldp      x20, x19, [sp, #0x10]
0064CB8AC  ldr      x30, [sp], #0x20
0064CB8B0  ret      
0064CB8B4  bl       #0x382be8c ; 
0064CB8B8  ldr      x8, [x19]
0064CB8BC  ldr      x8, [x8, #0xb8]
0064CB8C0  cbnz     w20, #0x64cb870
0064CB8C4  b        #0x64cb8a4 ; 

