; LocalModels.Bean.CrossArena_CrossArena$$readImpl
; RVA 0x68D15E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D15E8  str      d8, [sp, #-0x30]!
0068D15EC  stp      x30, x21, [sp, #0x10]
0068D15F0  stp      x20, x19, [sp, #0x20]
0068D15F4  adrp     x20, #0x959c000
0068D15F8  adrp     x21, #0x8f28000
0068D15FC  ldrb     w8, [x20, #0x3cd]
0068D1600  ldr      x21, [x21, #0x7a8]
0068D1604  mov      x19, x0
0068D1608  tbnz     w8, #0, #0x68d1620
0068D160C  adrp     x0, #0x8f28000
0068D1610  ldr      x0, [x0, #0x7a8]
0068D1614  bl       #0x382bd14 ; 
0068D1618  mov      w8, #1
0068D161C  strb     w8, [x20, #0x3cd]
0068D1620  ldr      x1, [x21]
0068D1624  ldrb     w8, [x1, #0x53]
0068D1628  tbnz     w8, #5, #0x68d1678
0068D162C  mov      x0, x19
0068D1630  mov      x1, xzr
0068D1634  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D1638  adrp     x21, #0x959c000
0068D163C  ldrb     w8, [x21, #0x759]
0068D1640  mov      w20, w0
0068D1644  cbnz     w8, #0x68d165c
0068D1648  adrp     x0, #0x8f28000
0068D164C  ldr      x0, [x0, #0x710]
0068D1650  bl       #0x382bd14 ; 
0068D1654  mov      w8, #1
0068D1658  strb     w8, [x21, #0x759]
0068D165C  adrp     x8, #0x8f28000
0068D1660  ldr      x8, [x8, #0x710]
0068D1664  ldr      x2, [x8]
0068D1668  ldrb     w8, [x2, #0x53]
0068D166C  tbnz     w8, #5, #0x68d1690
0068D1670  str      w20, [x19, #0x20]
0068D1674  b        #0x68d16a0 ; 
0068D1678  ldr      x2, [x1, #0x60]
0068D167C  mov      x0, x19
0068D1680  ldp      x20, x19, [sp, #0x20]
0068D1684  ldp      x30, x21, [sp, #0x10]
0068D1688  ldr      d8, [sp], #0x30
0068D168C  br       x2
0068D1690  ldr      x8, [x2, #0x60]
0068D1694  mov      x0, x19
0068D1698  mov      w1, w20
0068D169C  blr      x8
0068D16A0  mov      x0, x19
0068D16A4  mov      x1, xzr
0068D16A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D16AC  adrp     x21, #0x959c000
0068D16B0  ldrb     w8, [x21, #0x75a]
0068D16B4  mov      w20, w0
0068D16B8  cbnz     w8, #0x68d16d0
0068D16BC  adrp     x0, #0x8f28000
0068D16C0  ldr      x0, [x0, #0x720]
0068D16C4  bl       #0x382bd14 ; 
0068D16C8  mov      w8, #1
0068D16CC  strb     w8, [x21, #0x75a]
0068D16D0  adrp     x8, #0x8f28000
0068D16D4  ldr      x8, [x8, #0x720]
0068D16D8  ldr      x2, [x8]
0068D16DC  ldrb     w8, [x2, #0x53]
0068D16E0  tbnz     w8, #5, #0x68d16ec
0068D16E4  str      w20, [x19, #0x24]
0068D16E8  b        #0x68d16fc ; 
0068D16EC  ldr      x8, [x2, #0x60]
0068D16F0  mov      x0, x19
0068D16F4  mov      w1, w20
0068D16F8  blr      x8
0068D16FC  mov      x0, x19
0068D1700  mov      x1, xzr
0068D1704  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D1708  adrp     x21, #0x959c000
0068D170C  ldrb     w8, [x21, #0x75b]
0068D1710  mov      w20, w0
0068D1714  cbnz     w8, #0x68d172c
0068D1718  adrp     x0, #0x8f28000
0068D171C  ldr      x0, [x0, #0x730]
0068D1720  bl       #0x382bd14 ; 
0068D1724  mov      w8, #1
0068D1728  strb     w8, [x21, #0x75b]
0068D172C  adrp     x8, #0x8f28000
0068D1730  ldr      x8, [x8, #0x730]
0068D1734  ldr      x2, [x8]
0068D1738  ldrb     w8, [x2, #0x53]
0068D173C  tbnz     w8, #5, #0x68d1748
0068D1740  str      w20, [x19, #0x28]
0068D1744  b        #0x68d1758 ; 
0068D1748  ldr      x8, [x2, #0x60]
0068D174C  mov      x0, x19
0068D1750  mov      w1, w20
0068D1754  blr      x8
0068D1758  mov      x0, x19
0068D175C  mov      x1, xzr
0068D1760  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D1764  adrp     x21, #0x959c000
0068D1768  ldrb     w8, [x21, #0x75c]
0068D176C  mov      w20, w0
0068D1770  cbnz     w8, #0x68d1788
0068D1774  adrp     x0, #0x8f28000
0068D1778  ldr      x0, [x0, #0x740]
0068D177C  bl       #0x382bd14 ; 
0068D1780  mov      w8, #1
0068D1784  strb     w8, [x21, #0x75c]
0068D1788  adrp     x8, #0x8f28000
0068D178C  ldr      x8, [x8, #0x740]
0068D1790  ldr      x2, [x8]
0068D1794  ldrb     w8, [x2, #0x53]
0068D1798  tbnz     w8, #5, #0x68d17a4
0068D179C  str      w20, [x19, #0x2c]
0068D17A0  b        #0x68d17b4 ; 
0068D17A4  ldr      x8, [x2, #0x60]
0068D17A8  mov      x0, x19
0068D17AC  mov      w1, w20
0068D17B0  blr      x8
0068D17B4  mov      x0, x19
0068D17B8  mov      x1, xzr
0068D17BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D17C0  adrp     x21, #0x959c000
0068D17C4  ldrb     w8, [x21, #0x75d]
0068D17C8  mov      w20, w0
0068D17CC  cbnz     w8, #0x68d17e4
0068D17D0  adrp     x0, #0x8f28000
0068D17D4  ldr      x0, [x0, #0x750]
0068D17D8  bl       #0x382bd14 ; 
0068D17DC  mov      w8, #1
0068D17E0  strb     w8, [x21, #0x75d]
0068D17E4  adrp     x8, #0x8f28000
0068D17E8  ldr      x8, [x8, #0x750]
0068D17EC  ldr      x2, [x8]
0068D17F0  ldrb     w8, [x2, #0x53]
0068D17F4  tbnz     w8, #5, #0x68d1800
0068D17F8  str      w20, [x19, #0x30]
0068D17FC  b        #0x68d1810 ; 
0068D1800  ldr      x8, [x2, #0x60]
0068D1804  mov      x0, x19
0068D1808  mov      w1, w20
0068D180C  blr      x8
0068D1810  mov      x0, x19
0068D1814  mov      x1, xzr
0068D1818  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068D181C  adrp     x20, #0x959c000
0068D1820  ldrb     w8, [x20, #0x75e]
0068D1824  mov      v8.16b, v0.16b
0068D1828  cbnz     w8, #0x68d1840
0068D182C  adrp     x0, #0x8f28000
0068D1830  ldr      x0, [x0, #0x760]
0068D1834  bl       #0x382bd14 ; 
0068D1838  mov      w8, #1
0068D183C  strb     w8, [x20, #0x75e]
0068D1840  adrp     x8, #0x8f28000
0068D1844  ldr      x8, [x8, #0x760]
0068D1848  ldr      x1, [x8]
0068D184C  ldrb     w8, [x1, #0x53]
0068D1850  tbnz     w8, #5, #0x68d185c
0068D1854  str      s8, [x19, #0x34]
0068D1858  b        #0x68d186c ; 
0068D185C  ldr      x8, [x1, #0x60]
0068D1860  mov      x0, x19
0068D1864  mov      v0.16b, v8.16b
0068D1868  blr      x8
0068D186C  mov      x0, x19
0068D1870  mov      x1, xzr
0068D1874  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068D1878  adrp     x21, #0x959c000
0068D187C  ldrb     w8, [x21, #0x75f]
0068D1880  mov      x20, x0
0068D1884  cbnz     w8, #0x68d189c
0068D1888  adrp     x0, #0x8f28000
0068D188C  ldr      x0, [x0, #0x770]
0068D1890  bl       #0x382bd14 ; 
0068D1894  mov      w8, #1
0068D1898  strb     w8, [x21, #0x75f]
0068D189C  adrp     x8, #0x8f28000
0068D18A0  ldr      x8, [x8, #0x770]
0068D18A4  ldr      x2, [x8]
0068D18A8  ldrb     w8, [x2, #0x53]
0068D18AC  tbnz     w8, #5, #0x68d18c4
0068D18B0  mov      x0, x19
0068D18B4  str      x20, [x0, #0x38]!
0068D18B8  mov      x1, x20
0068D18BC  bl       #0x382bcb8 ; 
0068D18C0  b        #0x68d18d4 ; 
0068D18C4  ldr      x8, [x2, #0x60]
0068D18C8  mov      x0, x19
0068D18CC  mov      x1, x20
0068D18D0  blr      x8
0068D18D4  mov      x0, x19
0068D18D8  mov      x1, xzr
0068D18DC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068D18E0  adrp     x21, #0x959c000
0068D18E4  ldrb     w8, [x21, #0x760]
0068D18E8  mov      x20, x0
0068D18EC  cbnz     w8, #0x68d1904
0068D18F0  adrp     x0, #0x8f28000
0068D18F4  ldr      x0, [x0, #0x780]
0068D18F8  bl       #0x382bd14 ; 
0068D18FC  mov      w8, #1
0068D1900  strb     w8, [x21, #0x760]
0068D1904  adrp     x8, #0x8f28000
0068D1908  ldr      x8, [x8, #0x780]
0068D190C  ldr      x2, [x8]
0068D1910  ldrb     w8, [x2, #0x53]
0068D1914  tbnz     w8, #5, #0x68d192c
0068D1918  mov      x0, x19
0068D191C  str      x20, [x0, #0x40]!
0068D1920  mov      x1, x20
0068D1924  bl       #0x382bcb8 ; 
0068D1928  b        #0x68d193c ; 
0068D192C  ldr      x8, [x2, #0x60]
0068D1930  mov      x0, x19
0068D1934  mov      x1, x20
0068D1938  blr      x8
0068D193C  mov      x0, x19
0068D1940  mov      x1, xzr
0068D1944  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068D1948  adrp     x21, #0x959c000
0068D194C  ldrb     w8, [x21, #0x761]
0068D1950  mov      x20, x0
0068D1954  cbnz     w8, #0x68d196c
0068D1958  adrp     x0, #0x8f28000
0068D195C  ldr      x0, [x0, #0x790]
0068D1960  bl       #0x382bd14 ; 
0068D1964  mov      w8, #1
0068D1968  strb     w8, [x21, #0x761]
0068D196C  adrp     x8, #0x8f28000
0068D1970  ldr      x8, [x8, #0x790]
0068D1974  ldr      x2, [x8]
0068D1978  ldrb     w8, [x2, #0x53]
0068D197C  tbnz     w8, #5, #0x68d1994
0068D1980  mov      x0, x19
0068D1984  str      x20, [x0, #0x48]!
0068D1988  mov      x1, x20
0068D198C  bl       #0x382bcb8 ; 
0068D1990  b        #0x68d19a4 ; 
0068D1994  ldr      x8, [x2, #0x60]
0068D1998  mov      x0, x19
0068D199C  mov      x1, x20
0068D19A0  blr      x8
0068D19A4  mov      x0, x19
0068D19A8  mov      x1, xzr
0068D19AC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068D19B0  adrp     x21, #0x959c000
0068D19B4  ldrb     w8, [x21, #0x762]
0068D19B8  mov      x20, x0
0068D19BC  cbnz     w8, #0x68d19d4
0068D19C0  adrp     x0, #0x8f28000
0068D19C4  ldr      x0, [x0, #0x7a0]
0068D19C8  bl       #0x382bd14 ; 
0068D19CC  mov      w8, #1
0068D19D0  strb     w8, [x21, #0x762]
0068D19D4  adrp     x8, #0x8f28000
0068D19D8  ldr      x8, [x8, #0x7a0]
0068D19DC  ldr      x2, [x8]
0068D19E0  ldrb     w8, [x2, #0x53]
0068D19E4  tbnz     w8, #5, #0x68d19fc
0068D19E8  str      x20, [x19, #0x50]!
0068D19EC  mov      x0, x19
0068D19F0  mov      x1, x20
0068D19F4  bl       #0x382bcb8 ; 
0068D19F8  b        #0x68d1a0c ; 
0068D19FC  ldr      x8, [x2, #0x60]
0068D1A00  mov      x0, x19
0068D1A04  mov      x1, x20
0068D1A08  blr      x8
0068D1A0C  ldp      x20, x19, [sp, #0x20]
0068D1A10  ldp      x30, x21, [sp, #0x10]
0068D1A14  mov      w0, #1
0068D1A18  ldr      d8, [sp], #0x30
0068D1A1C  ret      

