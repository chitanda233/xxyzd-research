; LocalModels.Bean.Chapter_MainChapter$$GetSkillGroupWeight
; RVA 0x68AFC9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068AFC9C  stp      x30, x21, [sp, #-0x20]!
0068AFCA0  stp      x20, x19, [sp, #0x10]
0068AFCA4  adrp     x20, #0x959c000
0068AFCA8  adrp     x21, #0x8f26000
0068AFCAC  ldrb     w8, [x20, #0x57]
0068AFCB0  ldr      x21, [x21, #0xeb0] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.GetSkillGroupWeight() @ 0x924ad60
0068AFCB4  mov      x19, x0
0068AFCB8  tbnz     w8, #0, #0x68afcdc
0068AFCBC  adrp     x0, #0x8f26000
0068AFCC0  ldr      x0, [x0, #0xeb0] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.GetSkillGroupWeight() @ 0x924ad60
0068AFCC4  bl       #0x382bd14 ; 
0068AFCC8  adrp     x0, #0x8ee8000
0068AFCCC  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068AFCD0  bl       #0x382bd14 ; 
0068AFCD4  mov      w8, #1
0068AFCD8  strb     w8, [x20, #0x57]
0068AFCDC  ldr      x1, [x21]
0068AFCE0  ldrb     w8, [x1, #0x53]
0068AFCE4  tbnz     w8, #5, #0x68afdec
0068AFCE8  adrp     x20, #0x8ee8000
0068AFCEC  ldr      x20, [x20, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068AFCF0  ldr      x0, [x20]
0068AFCF4  ldr      w8, [x0, #0xe0]
0068AFCF8  cbnz     w8, #0x68afd00
0068AFCFC  bl       #0x382be8c ; 
0068AFD00  adrp     x21, #0x959b000
0068AFD04  ldrb     w8, [x21, #0xb85]
0068AFD08  cbnz     w8, #0x68afd2c
0068AFD0C  adrp     x0, #0x8efa000
0068AFD10  ldr      x0, [x0, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
0068AFD14  bl       #0x382bd14 ; 
0068AFD18  adrp     x0, #0x8ee8000
0068AFD1C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068AFD20  bl       #0x382bd14 ; 
0068AFD24  mov      w8, #1
0068AFD28  strb     w8, [x21, #0xb85]
0068AFD2C  adrp     x8, #0x8efa000
0068AFD30  ldr      x8, [x8, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
0068AFD34  ldr      x0, [x8]
0068AFD38  ldrb     w8, [x0, #0x53]
0068AFD3C  tbnz     w8, #5, #0x68afd9c
0068AFD40  ldr      x0, [x20]
0068AFD44  ldr      w8, [x0, #0xe0]
0068AFD48  cbnz     w8, #0x68afd54
0068AFD4C  bl       #0x382be8c ; 
0068AFD50  ldr      x0, [x20]
0068AFD54  ldr      x8, [x0, #0xb8]
0068AFD58  ldrb     w8, [x8, #0x530]
0068AFD5C  cbz      w8, #0x68afda8
0068AFD60  adrp     x20, #0x959c000
0068AFD64  ldrb     w8, [x20, #0x5d6]
0068AFD68  cbnz     w8, #0x68afd80
0068AFD6C  adrp     x0, #0x8f26000
0068AFD70  ldr      x0, [x0, #0xb08] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_SkillGroupWeight_B() @ 0x924ae30
0068AFD74  bl       #0x382bd14 ; 
0068AFD78  mov      w8, #1
0068AFD7C  strb     w8, [x20, #0x5d6]
0068AFD80  adrp     x8, #0x8f26000
0068AFD84  ldr      x8, [x8, #0xb08] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_SkillGroupWeight_B() @ 0x924ae30
0068AFD88  ldr      x1, [x8]
0068AFD8C  ldrb     w8, [x1, #0x53]
0068AFD90  tbnz     w8, #5, #0x68afdec
0068AFD94  ldr      w0, [x19, #0x38]
0068AFD98  b        #0x68afde0 ; 
0068AFD9C  ldr      x8, [x0, #0x60]
0068AFDA0  blr      x8
0068AFDA4  tbnz     w0, #0, #0x68afd60
0068AFDA8  adrp     x20, #0x959c000
0068AFDAC  ldrb     w8, [x20, #0x5d5]
0068AFDB0  cbnz     w8, #0x68afdc8
0068AFDB4  adrp     x0, #0x8f26000
0068AFDB8  ldr      x0, [x0, #0xaf8] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_SkillGroupWeight() @ 0x924ae28
0068AFDBC  bl       #0x382bd14 ; 
0068AFDC0  mov      w8, #1
0068AFDC4  strb     w8, [x20, #0x5d5]
0068AFDC8  adrp     x8, #0x8f26000
0068AFDCC  ldr      x8, [x8, #0xaf8] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_SkillGroupWeight() @ 0x924ae28
0068AFDD0  ldr      x1, [x8]
0068AFDD4  ldrb     w8, [x1, #0x53]
0068AFDD8  tbnz     w8, #5, #0x68afdec
0068AFDDC  ldr      w0, [x19, #0x34]
0068AFDE0  ldp      x20, x19, [sp, #0x10]
0068AFDE4  ldp      x30, x21, [sp], #0x20
0068AFDE8  ret      
0068AFDEC  ldr      x2, [x1, #0x60]
0068AFDF0  mov      x0, x19
0068AFDF4  ldp      x20, x19, [sp, #0x10]
0068AFDF8  ldp      x30, x21, [sp], #0x20
0068AFDFC  br       x2

