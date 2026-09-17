; LocalModels.Bean.Chapter_ProtectTemplate$$readImpl
; RVA 0x68B4FDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B4FDC  str      d8, [sp, #-0x30]!
0068B4FE0  stp      x30, x21, [sp, #0x10]
0068B4FE4  stp      x20, x19, [sp, #0x20]
0068B4FE8  adrp     x20, #0x959c000
0068B4FEC  adrp     x21, #0x8f27000
0068B4FF0  ldrb     w8, [x20, #0xe5]
0068B4FF4  ldr      x21, [x21, #0x2f8]
0068B4FF8  mov      x19, x0
0068B4FFC  tbnz     w8, #0, #0x68b5014
0068B5000  adrp     x0, #0x8f27000
0068B5004  ldr      x0, [x0, #0x2f8]
0068B5008  bl       #0x382bd14 ; 
0068B500C  mov      w8, #1
0068B5010  strb     w8, [x20, #0xe5]
0068B5014  ldr      x1, [x21]
0068B5018  ldrb     w8, [x1, #0x53]
0068B501C  tbnz     w8, #5, #0x68b506c
0068B5020  mov      x0, x19
0068B5024  mov      x1, xzr
0068B5028  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B502C  adrp     x21, #0x959c000
0068B5030  ldrb     w8, [x21, #0x60d]
0068B5034  mov      w20, w0
0068B5038  cbnz     w8, #0x68b5050
0068B503C  adrp     x0, #0x8f27000
0068B5040  ldr      x0, [x0, #0x250]
0068B5044  bl       #0x382bd14 ; 
0068B5048  mov      w8, #1
0068B504C  strb     w8, [x21, #0x60d]
0068B5050  adrp     x8, #0x8f27000
0068B5054  ldr      x8, [x8, #0x250]
0068B5058  ldr      x2, [x8]
0068B505C  ldrb     w8, [x2, #0x53]
0068B5060  tbnz     w8, #5, #0x68b5084
0068B5064  str      w20, [x19, #0x20]
0068B5068  b        #0x68b5094 ; 
0068B506C  ldr      x2, [x1, #0x60]
0068B5070  mov      x0, x19
0068B5074  ldp      x20, x19, [sp, #0x20]
0068B5078  ldp      x30, x21, [sp, #0x10]
0068B507C  ldr      d8, [sp], #0x30
0068B5080  br       x2
0068B5084  ldr      x8, [x2, #0x60]
0068B5088  mov      x0, x19
0068B508C  mov      w1, w20
0068B5090  blr      x8
0068B5094  mov      x0, x19
0068B5098  mov      x1, xzr
0068B509C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B50A0  adrp     x20, #0x959c000
0068B50A4  ldrb     w8, [x20, #0x60e]
0068B50A8  mov      v8.16b, v0.16b
0068B50AC  cbnz     w8, #0x68b50c4
0068B50B0  adrp     x0, #0x8f27000
0068B50B4  ldr      x0, [x0, #0x260]
0068B50B8  bl       #0x382bd14 ; 
0068B50BC  mov      w8, #1
0068B50C0  strb     w8, [x20, #0x60e]
0068B50C4  adrp     x8, #0x8f27000
0068B50C8  ldr      x8, [x8, #0x260]
0068B50CC  ldr      x1, [x8]
0068B50D0  ldrb     w8, [x1, #0x53]
0068B50D4  tbnz     w8, #5, #0x68b50e0
0068B50D8  str      s8, [x19, #0x24]
0068B50DC  b        #0x68b50f0 ; 
0068B50E0  ldr      x8, [x1, #0x60]
0068B50E4  mov      x0, x19
0068B50E8  mov      v0.16b, v8.16b
0068B50EC  blr      x8
0068B50F0  mov      x0, x19
0068B50F4  mov      x1, xzr
0068B50F8  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B50FC  adrp     x20, #0x959c000
0068B5100  ldrb     w8, [x20, #0x60f]
0068B5104  mov      v8.16b, v0.16b
0068B5108  cbnz     w8, #0x68b5120
0068B510C  adrp     x0, #0x8f27000
0068B5110  ldr      x0, [x0, #0x270]
0068B5114  bl       #0x382bd14 ; 
0068B5118  mov      w8, #1
0068B511C  strb     w8, [x20, #0x60f]
0068B5120  adrp     x8, #0x8f27000
0068B5124  ldr      x8, [x8, #0x270]
0068B5128  ldr      x1, [x8]
0068B512C  ldrb     w8, [x1, #0x53]
0068B5130  tbnz     w8, #5, #0x68b513c
0068B5134  str      s8, [x19, #0x28]
0068B5138  b        #0x68b514c ; 
0068B513C  ldr      x8, [x1, #0x60]
0068B5140  mov      x0, x19
0068B5144  mov      v0.16b, v8.16b
0068B5148  blr      x8
0068B514C  mov      x0, x19
0068B5150  mov      x1, xzr
0068B5154  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B5158  adrp     x20, #0x959c000
0068B515C  ldrb     w8, [x20, #0x610]
0068B5160  mov      v8.16b, v0.16b
0068B5164  cbnz     w8, #0x68b517c
0068B5168  adrp     x0, #0x8f27000
0068B516C  ldr      x0, [x0, #0x280]
0068B5170  bl       #0x382bd14 ; 
0068B5174  mov      w8, #1
0068B5178  strb     w8, [x20, #0x610]
0068B517C  adrp     x8, #0x8f27000
0068B5180  ldr      x8, [x8, #0x280]
0068B5184  ldr      x1, [x8]
0068B5188  ldrb     w8, [x1, #0x53]
0068B518C  tbnz     w8, #5, #0x68b5198
0068B5190  str      s8, [x19, #0x2c]
0068B5194  b        #0x68b51a8 ; 
0068B5198  ldr      x8, [x1, #0x60]
0068B519C  mov      x0, x19
0068B51A0  mov      v0.16b, v8.16b
0068B51A4  blr      x8
0068B51A8  mov      x0, x19
0068B51AC  mov      x1, xzr
0068B51B0  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B51B4  adrp     x20, #0x959c000
0068B51B8  ldrb     w8, [x20, #0x611]
0068B51BC  mov      v8.16b, v0.16b
0068B51C0  cbnz     w8, #0x68b51d8
0068B51C4  adrp     x0, #0x8f27000
0068B51C8  ldr      x0, [x0, #0x290]
0068B51CC  bl       #0x382bd14 ; 
0068B51D0  mov      w8, #1
0068B51D4  strb     w8, [x20, #0x611]
0068B51D8  adrp     x8, #0x8f27000
0068B51DC  ldr      x8, [x8, #0x290]
0068B51E0  ldr      x1, [x8]
0068B51E4  ldrb     w8, [x1, #0x53]
0068B51E8  tbnz     w8, #5, #0x68b51f4
0068B51EC  str      s8, [x19, #0x30]
0068B51F0  b        #0x68b5204 ; 
0068B51F4  ldr      x8, [x1, #0x60]
0068B51F8  mov      x0, x19
0068B51FC  mov      v0.16b, v8.16b
0068B5200  blr      x8
0068B5204  mov      x0, x19
0068B5208  mov      x1, xzr
0068B520C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B5210  adrp     x20, #0x959c000
0068B5214  ldrb     w8, [x20, #0x612]
0068B5218  mov      v8.16b, v0.16b
0068B521C  cbnz     w8, #0x68b5234
0068B5220  adrp     x0, #0x8f27000
0068B5224  ldr      x0, [x0, #0x2a0]
0068B5228  bl       #0x382bd14 ; 
0068B522C  mov      w8, #1
0068B5230  strb     w8, [x20, #0x612]
0068B5234  adrp     x8, #0x8f27000
0068B5238  ldr      x8, [x8, #0x2a0]
0068B523C  ldr      x1, [x8]
0068B5240  ldrb     w8, [x1, #0x53]
0068B5244  tbnz     w8, #5, #0x68b5250
0068B5248  str      s8, [x19, #0x34]
0068B524C  b        #0x68b5260 ; 
0068B5250  ldr      x8, [x1, #0x60]
0068B5254  mov      x0, x19
0068B5258  mov      v0.16b, v8.16b
0068B525C  blr      x8
0068B5260  mov      x0, x19
0068B5264  mov      x1, xzr
0068B5268  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B526C  adrp     x20, #0x959c000
0068B5270  ldrb     w8, [x20, #0x613]
0068B5274  mov      v8.16b, v0.16b
0068B5278  cbnz     w8, #0x68b5290
0068B527C  adrp     x0, #0x8f27000
0068B5280  ldr      x0, [x0, #0x2b0]
0068B5284  bl       #0x382bd14 ; 
0068B5288  mov      w8, #1
0068B528C  strb     w8, [x20, #0x613]
0068B5290  adrp     x8, #0x8f27000
0068B5294  ldr      x8, [x8, #0x2b0]
0068B5298  ldr      x1, [x8]
0068B529C  ldrb     w8, [x1, #0x53]
0068B52A0  tbnz     w8, #5, #0x68b52ac
0068B52A4  str      s8, [x19, #0x38]
0068B52A8  b        #0x68b52bc ; 
0068B52AC  ldr      x8, [x1, #0x60]
0068B52B0  mov      x0, x19
0068B52B4  mov      v0.16b, v8.16b
0068B52B8  blr      x8
0068B52BC  mov      x0, x19
0068B52C0  mov      x1, xzr
0068B52C4  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B52C8  adrp     x20, #0x959c000
0068B52CC  ldrb     w8, [x20, #0x614]
0068B52D0  mov      v8.16b, v0.16b
0068B52D4  cbnz     w8, #0x68b52ec
0068B52D8  adrp     x0, #0x8f27000
0068B52DC  ldr      x0, [x0, #0x2c0]
0068B52E0  bl       #0x382bd14 ; 
0068B52E4  mov      w8, #1
0068B52E8  strb     w8, [x20, #0x614]
0068B52EC  adrp     x8, #0x8f27000
0068B52F0  ldr      x8, [x8, #0x2c0]
0068B52F4  ldr      x1, [x8]
0068B52F8  ldrb     w8, [x1, #0x53]
0068B52FC  tbnz     w8, #5, #0x68b5308
0068B5300  str      s8, [x19, #0x3c]
0068B5304  b        #0x68b5318 ; 
0068B5308  ldr      x8, [x1, #0x60]
0068B530C  mov      x0, x19
0068B5310  mov      v0.16b, v8.16b
0068B5314  blr      x8
0068B5318  mov      x0, x19
0068B531C  mov      x1, xzr
0068B5320  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B5324  adrp     x20, #0x959c000
0068B5328  ldrb     w8, [x20, #0x615]
0068B532C  mov      v8.16b, v0.16b
0068B5330  cbnz     w8, #0x68b5348
0068B5334  adrp     x0, #0x8f27000
0068B5338  ldr      x0, [x0, #0x2d0]
0068B533C  bl       #0x382bd14 ; 
0068B5340  mov      w8, #1
0068B5344  strb     w8, [x20, #0x615]
0068B5348  adrp     x8, #0x8f27000
0068B534C  ldr      x8, [x8, #0x2d0]
0068B5350  ldr      x1, [x8]
0068B5354  ldrb     w8, [x1, #0x53]
0068B5358  tbnz     w8, #5, #0x68b5364
0068B535C  str      s8, [x19, #0x40]
0068B5360  b        #0x68b5374 ; 
0068B5364  ldr      x8, [x1, #0x60]
0068B5368  mov      x0, x19
0068B536C  mov      v0.16b, v8.16b
0068B5370  blr      x8
0068B5374  mov      x0, x19
0068B5378  mov      x1, xzr
0068B537C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B5380  adrp     x20, #0x959c000
0068B5384  ldrb     w8, [x20, #0x616]
0068B5388  mov      v8.16b, v0.16b
0068B538C  cbnz     w8, #0x68b53a4
0068B5390  adrp     x0, #0x8f27000
0068B5394  ldr      x0, [x0, #0x2e0]
0068B5398  bl       #0x382bd14 ; 
0068B539C  mov      w8, #1
0068B53A0  strb     w8, [x20, #0x616]
0068B53A4  adrp     x8, #0x8f27000
0068B53A8  ldr      x8, [x8, #0x2e0]
0068B53AC  ldr      x1, [x8]
0068B53B0  ldrb     w8, [x1, #0x53]
0068B53B4  tbnz     w8, #5, #0x68b53c0
0068B53B8  str      s8, [x19, #0x44]
0068B53BC  b        #0x68b53d0 ; 
0068B53C0  ldr      x8, [x1, #0x60]
0068B53C4  mov      x0, x19
0068B53C8  mov      v0.16b, v8.16b
0068B53CC  blr      x8
0068B53D0  mov      x0, x19
0068B53D4  mov      x1, xzr
0068B53D8  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068B53DC  adrp     x20, #0x959c000
0068B53E0  ldrb     w8, [x20, #0x617]
0068B53E4  mov      v8.16b, v0.16b
0068B53E8  cbnz     w8, #0x68b5400
0068B53EC  adrp     x0, #0x8f27000
0068B53F0  ldr      x0, [x0, #0x2f0]
0068B53F4  bl       #0x382bd14 ; 
0068B53F8  mov      w8, #1
0068B53FC  strb     w8, [x20, #0x617]
0068B5400  adrp     x8, #0x8f27000
0068B5404  ldr      x8, [x8, #0x2f0]
0068B5408  ldr      x1, [x8]
0068B540C  ldrb     w8, [x1, #0x53]
0068B5410  tbnz     w8, #5, #0x68b541c
0068B5414  str      s8, [x19, #0x48]
0068B5418  b        #0x68b542c ; 
0068B541C  ldr      x8, [x1, #0x60]
0068B5420  mov      x0, x19
0068B5424  mov      v0.16b, v8.16b
0068B5428  blr      x8
0068B542C  ldp      x20, x19, [sp, #0x20]
0068B5430  ldp      x30, x21, [sp, #0x10]
0068B5434  mov      w0, #1
0068B5438  ldr      d8, [sp], #0x30
0068B543C  ret      

