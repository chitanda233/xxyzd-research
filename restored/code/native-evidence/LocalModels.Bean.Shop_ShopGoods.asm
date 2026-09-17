; LocalModels.Bean.Shop_ShopGoods$$readImpl
; RVA 0x6AF167C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF167C  stp      x30, x21, [sp, #-0x20]!
006AF1680  stp      x20, x19, [sp, #0x10]
006AF1684  adrp     x20, #0x959e000
006AF1688  adrp     x21, #0x8f3d000
006AF168C  ldrb     w8, [x20, #0xe83]
006AF1690  ldr      x21, [x21, #0x728]
006AF1694  mov      x19, x0
006AF1698  tbnz     w8, #0, #0x6af16b0
006AF169C  adrp     x0, #0x8f3d000
006AF16A0  ldr      x0, [x0, #0x728]
006AF16A4  bl       #0x382bd14 ; 
006AF16A8  mov      w8, #1
006AF16AC  strb     w8, [x20, #0xe83]
006AF16B0  ldr      x1, [x21]
006AF16B4  ldrb     w8, [x1, #0x53]
006AF16B8  tbnz     w8, #5, #0x6af1708
006AF16BC  mov      x0, x19
006AF16C0  mov      x1, xzr
006AF16C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF16C8  adrp     x21, #0x959f000
006AF16CC  ldrb     w8, [x21, #0x244]
006AF16D0  mov      w20, w0
006AF16D4  cbnz     w8, #0x6af16ec
006AF16D8  adrp     x0, #0x8f3d000
006AF16DC  ldr      x0, [x0, #0x5f0]
006AF16E0  bl       #0x382bd14 ; 
006AF16E4  mov      w8, #1
006AF16E8  strb     w8, [x21, #0x244]
006AF16EC  adrp     x8, #0x8f3d000
006AF16F0  ldr      x8, [x8, #0x5f0]
006AF16F4  ldr      x2, [x8]
006AF16F8  ldrb     w8, [x2, #0x53]
006AF16FC  tbnz     w8, #5, #0x6af171c
006AF1700  str      w20, [x19, #0x20]
006AF1704  b        #0x6af172c ; 
006AF1708  ldr      x2, [x1, #0x60]
006AF170C  mov      x0, x19
006AF1710  ldp      x20, x19, [sp, #0x10]
006AF1714  ldp      x30, x21, [sp], #0x20
006AF1718  br       x2
006AF171C  ldr      x8, [x2, #0x60]
006AF1720  mov      x0, x19
006AF1724  mov      w1, w20
006AF1728  blr      x8
006AF172C  mov      x0, x19
006AF1730  mov      x1, xzr
006AF1734  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF1738  adrp     x21, #0x959f000
006AF173C  ldrb     w8, [x21, #0x245]
006AF1740  mov      x20, x0
006AF1744  cbnz     w8, #0x6af175c
006AF1748  adrp     x0, #0x8f3d000
006AF174C  ldr      x0, [x0, #0x600]
006AF1750  bl       #0x382bd14 ; 
006AF1754  mov      w8, #1
006AF1758  strb     w8, [x21, #0x245]
006AF175C  adrp     x8, #0x8f3d000
006AF1760  ldr      x8, [x8, #0x600]
006AF1764  ldr      x2, [x8]
006AF1768  ldrb     w8, [x2, #0x53]
006AF176C  tbnz     w8, #5, #0x6af1784
006AF1770  mov      x0, x19
006AF1774  str      x20, [x0, #0x28]!
006AF1778  mov      x1, x20
006AF177C  bl       #0x382bcb8 ; 
006AF1780  b        #0x6af1794 ; 
006AF1784  ldr      x8, [x2, #0x60]
006AF1788  mov      x0, x19
006AF178C  mov      x1, x20
006AF1790  blr      x8
006AF1794  mov      x0, x19
006AF1798  mov      x1, xzr
006AF179C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF17A0  adrp     x21, #0x959f000
006AF17A4  ldrb     w8, [x21, #0x246]
006AF17A8  mov      x20, x0
006AF17AC  cbnz     w8, #0x6af17c4
006AF17B0  adrp     x0, #0x8f3d000
006AF17B4  ldr      x0, [x0, #0x610]
006AF17B8  bl       #0x382bd14 ; 
006AF17BC  mov      w8, #1
006AF17C0  strb     w8, [x21, #0x246]
006AF17C4  adrp     x8, #0x8f3d000
006AF17C8  ldr      x8, [x8, #0x610]
006AF17CC  ldr      x2, [x8]
006AF17D0  ldrb     w8, [x2, #0x53]
006AF17D4  tbnz     w8, #5, #0x6af17ec
006AF17D8  mov      x0, x19
006AF17DC  str      x20, [x0, #0x30]!
006AF17E0  mov      x1, x20
006AF17E4  bl       #0x382bcb8 ; 
006AF17E8  b        #0x6af17fc ; 
006AF17EC  ldr      x8, [x2, #0x60]
006AF17F0  mov      x0, x19
006AF17F4  mov      x1, x20
006AF17F8  blr      x8
006AF17FC  mov      x0, x19
006AF1800  mov      x1, xzr
006AF1804  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AF1808  adrp     x21, #0x959f000
006AF180C  ldrb     w8, [x21, #0x247]
006AF1810  mov      x20, x0
006AF1814  cbnz     w8, #0x6af182c
006AF1818  adrp     x0, #0x8f3d000
006AF181C  ldr      x0, [x0, #0x620]
006AF1820  bl       #0x382bd14 ; 
006AF1824  mov      w8, #1
006AF1828  strb     w8, [x21, #0x247]
006AF182C  adrp     x8, #0x8f3d000
006AF1830  ldr      x8, [x8, #0x620]
006AF1834  ldr      x2, [x8]
006AF1838  ldrb     w8, [x2, #0x53]
006AF183C  tbnz     w8, #5, #0x6af1854
006AF1840  mov      x0, x19
006AF1844  str      x20, [x0, #0x38]!
006AF1848  mov      x1, x20
006AF184C  bl       #0x382bcb8 ; 
006AF1850  b        #0x6af1864 ; 
006AF1854  ldr      x8, [x2, #0x60]
006AF1858  mov      x0, x19
006AF185C  mov      x1, x20
006AF1860  blr      x8
006AF1864  mov      x0, x19
006AF1868  mov      x1, xzr
006AF186C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1870  adrp     x21, #0x959f000
006AF1874  ldrb     w8, [x21, #0x248]
006AF1878  mov      w20, w0
006AF187C  cbnz     w8, #0x6af1894
006AF1880  adrp     x0, #0x8f3d000
006AF1884  ldr      x0, [x0, #0x630]
006AF1888  bl       #0x382bd14 ; 
006AF188C  mov      w8, #1
006AF1890  strb     w8, [x21, #0x248]
006AF1894  adrp     x8, #0x8f3d000
006AF1898  ldr      x8, [x8, #0x630]
006AF189C  ldr      x2, [x8]
006AF18A0  ldrb     w8, [x2, #0x53]
006AF18A4  tbnz     w8, #5, #0x6af18b0
006AF18A8  str      w20, [x19, #0x40]
006AF18AC  b        #0x6af18c0 ; 
006AF18B0  ldr      x8, [x2, #0x60]
006AF18B4  mov      x0, x19
006AF18B8  mov      w1, w20
006AF18BC  blr      x8
006AF18C0  mov      x0, x19
006AF18C4  mov      x1, xzr
006AF18C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF18CC  adrp     x21, #0x959f000
006AF18D0  ldrb     w8, [x21, #0x249]
006AF18D4  mov      x20, x0
006AF18D8  cbnz     w8, #0x6af18f0
006AF18DC  adrp     x0, #0x8f3d000
006AF18E0  ldr      x0, [x0, #0x640]
006AF18E4  bl       #0x382bd14 ; 
006AF18E8  mov      w8, #1
006AF18EC  strb     w8, [x21, #0x249]
006AF18F0  adrp     x8, #0x8f3d000
006AF18F4  ldr      x8, [x8, #0x640]
006AF18F8  ldr      x2, [x8]
006AF18FC  ldrb     w8, [x2, #0x53]
006AF1900  tbnz     w8, #5, #0x6af1918
006AF1904  mov      x0, x19
006AF1908  str      x20, [x0, #0x48]!
006AF190C  mov      x1, x20
006AF1910  bl       #0x382bcb8 ; 
006AF1914  b        #0x6af1928 ; 
006AF1918  ldr      x8, [x2, #0x60]
006AF191C  mov      x0, x19
006AF1920  mov      x1, x20
006AF1924  blr      x8
006AF1928  mov      x0, x19
006AF192C  mov      x1, xzr
006AF1930  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1934  adrp     x21, #0x959f000
006AF1938  ldrb     w8, [x21, #0x24a]
006AF193C  mov      w20, w0
006AF1940  cbnz     w8, #0x6af1958
006AF1944  adrp     x0, #0x8f3d000
006AF1948  ldr      x0, [x0, #0x650]
006AF194C  bl       #0x382bd14 ; 
006AF1950  mov      w8, #1
006AF1954  strb     w8, [x21, #0x24a]
006AF1958  adrp     x8, #0x8f3d000
006AF195C  ldr      x8, [x8, #0x650]
006AF1960  ldr      x2, [x8]
006AF1964  ldrb     w8, [x2, #0x53]
006AF1968  tbnz     w8, #5, #0x6af1974
006AF196C  str      w20, [x19, #0x50]
006AF1970  b        #0x6af1984 ; 
006AF1974  ldr      x8, [x2, #0x60]
006AF1978  mov      x0, x19
006AF197C  mov      w1, w20
006AF1980  blr      x8
006AF1984  mov      x0, x19
006AF1988  mov      x1, xzr
006AF198C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1990  adrp     x21, #0x959f000
006AF1994  ldrb     w8, [x21, #0x24b]
006AF1998  mov      w20, w0
006AF199C  cbnz     w8, #0x6af19b4
006AF19A0  adrp     x0, #0x8f3d000
006AF19A4  ldr      x0, [x0, #0x660]
006AF19A8  bl       #0x382bd14 ; 
006AF19AC  mov      w8, #1
006AF19B0  strb     w8, [x21, #0x24b]
006AF19B4  adrp     x8, #0x8f3d000
006AF19B8  ldr      x8, [x8, #0x660]
006AF19BC  ldr      x2, [x8]
006AF19C0  ldrb     w8, [x2, #0x53]
006AF19C4  tbnz     w8, #5, #0x6af19d0
006AF19C8  str      w20, [x19, #0x54]
006AF19CC  b        #0x6af19e0 ; 
006AF19D0  ldr      x8, [x2, #0x60]
006AF19D4  mov      x0, x19
006AF19D8  mov      w1, w20
006AF19DC  blr      x8
006AF19E0  mov      x0, x19
006AF19E4  mov      x1, xzr
006AF19E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF19EC  adrp     x21, #0x959f000
006AF19F0  ldrb     w8, [x21, #0x24c]
006AF19F4  mov      w20, w0
006AF19F8  cbnz     w8, #0x6af1a10
006AF19FC  adrp     x0, #0x8f3d000
006AF1A00  ldr      x0, [x0, #0x670]
006AF1A04  bl       #0x382bd14 ; 
006AF1A08  mov      w8, #1
006AF1A0C  strb     w8, [x21, #0x24c]
006AF1A10  adrp     x8, #0x8f3d000
006AF1A14  ldr      x8, [x8, #0x670]
006AF1A18  ldr      x2, [x8]
006AF1A1C  ldrb     w8, [x2, #0x53]
006AF1A20  tbnz     w8, #5, #0x6af1a2c
006AF1A24  str      w20, [x19, #0x58]
006AF1A28  b        #0x6af1a3c ; 
006AF1A2C  ldr      x8, [x2, #0x60]
006AF1A30  mov      x0, x19
006AF1A34  mov      w1, w20
006AF1A38  blr      x8
006AF1A3C  mov      x0, x19
006AF1A40  mov      x1, xzr
006AF1A44  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AF1A48  adrp     x21, #0x959f000
006AF1A4C  ldrb     w8, [x21, #0x24d]
006AF1A50  mov      x20, x0
006AF1A54  cbnz     w8, #0x6af1a6c
006AF1A58  adrp     x0, #0x8f3d000
006AF1A5C  ldr      x0, [x0, #0x680]
006AF1A60  bl       #0x382bd14 ; 
006AF1A64  mov      w8, #1
006AF1A68  strb     w8, [x21, #0x24d]
006AF1A6C  adrp     x8, #0x8f3d000
006AF1A70  ldr      x8, [x8, #0x680]
006AF1A74  ldr      x2, [x8]
006AF1A78  ldrb     w8, [x2, #0x53]
006AF1A7C  tbnz     w8, #5, #0x6af1a94
006AF1A80  mov      x0, x19
006AF1A84  str      x20, [x0, #0x60]!
006AF1A88  mov      x1, x20
006AF1A8C  bl       #0x382bcb8 ; 
006AF1A90  b        #0x6af1aa4 ; 
006AF1A94  ldr      x8, [x2, #0x60]
006AF1A98  mov      x0, x19
006AF1A9C  mov      x1, x20
006AF1AA0  blr      x8
006AF1AA4  mov      x0, x19
006AF1AA8  mov      x1, xzr
006AF1AAC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AF1AB0  adrp     x21, #0x959f000
006AF1AB4  ldrb     w8, [x21, #0x24e]
006AF1AB8  mov      x20, x0
006AF1ABC  cbnz     w8, #0x6af1ad4
006AF1AC0  adrp     x0, #0x8f3d000
006AF1AC4  ldr      x0, [x0, #0x690]
006AF1AC8  bl       #0x382bd14 ; 
006AF1ACC  mov      w8, #1
006AF1AD0  strb     w8, [x21, #0x24e]
006AF1AD4  adrp     x8, #0x8f3d000
006AF1AD8  ldr      x8, [x8, #0x690]
006AF1ADC  ldr      x2, [x8]
006AF1AE0  ldrb     w8, [x2, #0x53]
006AF1AE4  tbnz     w8, #5, #0x6af1afc
006AF1AE8  mov      x0, x19
006AF1AEC  str      x20, [x0, #0x68]!
006AF1AF0  mov      x1, x20
006AF1AF4  bl       #0x382bcb8 ; 
006AF1AF8  b        #0x6af1b0c ; 
006AF1AFC  ldr      x8, [x2, #0x60]
006AF1B00  mov      x0, x19
006AF1B04  mov      x1, x20
006AF1B08  blr      x8
006AF1B0C  mov      x0, x19
006AF1B10  mov      x1, xzr
006AF1B14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1B18  adrp     x21, #0x959f000
006AF1B1C  ldrb     w8, [x21, #0x24f]
006AF1B20  mov      w20, w0
006AF1B24  cbnz     w8, #0x6af1b3c
006AF1B28  adrp     x0, #0x8f3d000
006AF1B2C  ldr      x0, [x0, #0x6a0]
006AF1B30  bl       #0x382bd14 ; 
006AF1B34  mov      w8, #1
006AF1B38  strb     w8, [x21, #0x24f]
006AF1B3C  adrp     x8, #0x8f3d000
006AF1B40  ldr      x8, [x8, #0x6a0]
006AF1B44  ldr      x2, [x8]
006AF1B48  ldrb     w8, [x2, #0x53]
006AF1B4C  tbnz     w8, #5, #0x6af1b58
006AF1B50  str      w20, [x19, #0x70]
006AF1B54  b        #0x6af1b68 ; 
006AF1B58  ldr      x8, [x2, #0x60]
006AF1B5C  mov      x0, x19
006AF1B60  mov      w1, w20
006AF1B64  blr      x8
006AF1B68  mov      x0, x19
006AF1B6C  mov      x1, xzr
006AF1B70  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF1B74  adrp     x21, #0x959f000
006AF1B78  ldrb     w8, [x21, #0x250]
006AF1B7C  mov      x20, x0
006AF1B80  cbnz     w8, #0x6af1b98
006AF1B84  adrp     x0, #0x8f3d000
006AF1B88  ldr      x0, [x0, #0x6b0]
006AF1B8C  bl       #0x382bd14 ; 
006AF1B90  mov      w8, #1
006AF1B94  strb     w8, [x21, #0x250]
006AF1B98  adrp     x8, #0x8f3d000
006AF1B9C  ldr      x8, [x8, #0x6b0]
006AF1BA0  ldr      x2, [x8]
006AF1BA4  ldrb     w8, [x2, #0x53]
006AF1BA8  tbnz     w8, #5, #0x6af1bc0
006AF1BAC  mov      x0, x19
006AF1BB0  str      x20, [x0, #0x78]!
006AF1BB4  mov      x1, x20
006AF1BB8  bl       #0x382bcb8 ; 
006AF1BBC  b        #0x6af1bd0 ; 
006AF1BC0  ldr      x8, [x2, #0x60]
006AF1BC4  mov      x0, x19
006AF1BC8  mov      x1, x20
006AF1BCC  blr      x8
006AF1BD0  mov      x0, x19
006AF1BD4  mov      x1, xzr
006AF1BD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1BDC  adrp     x21, #0x959f000
006AF1BE0  ldrb     w8, [x21, #0x251]
006AF1BE4  mov      w20, w0
006AF1BE8  cbnz     w8, #0x6af1c00
006AF1BEC  adrp     x0, #0x8f3d000
006AF1BF0  ldr      x0, [x0, #0x6c0]
006AF1BF4  bl       #0x382bd14 ; 
006AF1BF8  mov      w8, #1
006AF1BFC  strb     w8, [x21, #0x251]
006AF1C00  adrp     x8, #0x8f3d000
006AF1C04  ldr      x8, [x8, #0x6c0]
006AF1C08  ldr      x2, [x8]
006AF1C0C  ldrb     w8, [x2, #0x53]
006AF1C10  tbnz     w8, #5, #0x6af1c1c
006AF1C14  str      w20, [x19, #0x80]
006AF1C18  b        #0x6af1c2c ; 
006AF1C1C  ldr      x8, [x2, #0x60]
006AF1C20  mov      x0, x19
006AF1C24  mov      w1, w20
006AF1C28  blr      x8
006AF1C2C  mov      x0, x19
006AF1C30  mov      x1, xzr
006AF1C34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1C38  adrp     x21, #0x959f000
006AF1C3C  ldrb     w8, [x21, #0x252]
006AF1C40  mov      w20, w0
006AF1C44  cbnz     w8, #0x6af1c5c
006AF1C48  adrp     x0, #0x8f3d000
006AF1C4C  ldr      x0, [x0, #0x6d0]
006AF1C50  bl       #0x382bd14 ; 
006AF1C54  mov      w8, #1
006AF1C58  strb     w8, [x21, #0x252]
006AF1C5C  adrp     x8, #0x8f3d000
006AF1C60  ldr      x8, [x8, #0x6d0]
006AF1C64  ldr      x2, [x8]
006AF1C68  ldrb     w8, [x2, #0x53]
006AF1C6C  tbnz     w8, #5, #0x6af1c78
006AF1C70  str      w20, [x19, #0x84]
006AF1C74  b        #0x6af1c88 ; 
006AF1C78  ldr      x8, [x2, #0x60]
006AF1C7C  mov      x0, x19
006AF1C80  mov      w1, w20
006AF1C84  blr      x8
006AF1C88  mov      x0, x19
006AF1C8C  mov      x1, xzr
006AF1C90  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF1C94  adrp     x21, #0x959f000
006AF1C98  ldrb     w8, [x21, #0x253]
006AF1C9C  mov      x20, x0
006AF1CA0  cbnz     w8, #0x6af1cb8
006AF1CA4  adrp     x0, #0x8f3d000
006AF1CA8  ldr      x0, [x0, #0x6e0]
006AF1CAC  bl       #0x382bd14 ; 
006AF1CB0  mov      w8, #1
006AF1CB4  strb     w8, [x21, #0x253]
006AF1CB8  adrp     x8, #0x8f3d000
006AF1CBC  ldr      x8, [x8, #0x6e0]
006AF1CC0  ldr      x2, [x8]
006AF1CC4  ldrb     w8, [x2, #0x53]
006AF1CC8  tbnz     w8, #5, #0x6af1ce0
006AF1CCC  mov      x0, x19
006AF1CD0  str      x20, [x0, #0x88]!
006AF1CD4  mov      x1, x20
006AF1CD8  bl       #0x382bcb8 ; 
006AF1CDC  b        #0x6af1cf0 ; 
006AF1CE0  ldr      x8, [x2, #0x60]
006AF1CE4  mov      x0, x19
006AF1CE8  mov      x1, x20
006AF1CEC  blr      x8
006AF1CF0  mov      x0, x19
006AF1CF4  mov      x1, xzr
006AF1CF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1CFC  adrp     x21, #0x959f000
006AF1D00  ldrb     w8, [x21, #0x254]
006AF1D04  mov      w20, w0
006AF1D08  cbnz     w8, #0x6af1d20
006AF1D0C  adrp     x0, #0x8f3d000
006AF1D10  ldr      x0, [x0, #0x6f0]
006AF1D14  bl       #0x382bd14 ; 
006AF1D18  mov      w8, #1
006AF1D1C  strb     w8, [x21, #0x254]
006AF1D20  adrp     x8, #0x8f3d000
006AF1D24  ldr      x8, [x8, #0x6f0]
006AF1D28  ldr      x2, [x8]
006AF1D2C  ldrb     w8, [x2, #0x53]
006AF1D30  tbnz     w8, #5, #0x6af1d3c
006AF1D34  str      w20, [x19, #0x90]
006AF1D38  b        #0x6af1d4c ; 
006AF1D3C  ldr      x8, [x2, #0x60]
006AF1D40  mov      x0, x19
006AF1D44  mov      w1, w20
006AF1D48  blr      x8
006AF1D4C  mov      x0, x19
006AF1D50  mov      x1, xzr
006AF1D54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1D58  adrp     x21, #0x959f000
006AF1D5C  ldrb     w8, [x21, #0x255]
006AF1D60  mov      w20, w0
006AF1D64  cbnz     w8, #0x6af1d7c
006AF1D68  adrp     x0, #0x8f3d000
006AF1D6C  ldr      x0, [x0, #0x700]
006AF1D70  bl       #0x382bd14 ; 
006AF1D74  mov      w8, #1
006AF1D78  strb     w8, [x21, #0x255]
006AF1D7C  adrp     x8, #0x8f3d000
006AF1D80  ldr      x8, [x8, #0x700]
006AF1D84  ldr      x2, [x8]
006AF1D88  ldrb     w8, [x2, #0x53]
006AF1D8C  tbnz     w8, #5, #0x6af1d98
006AF1D90  str      w20, [x19, #0x94]
006AF1D94  b        #0x6af1da8 ; 
006AF1D98  ldr      x8, [x2, #0x60]
006AF1D9C  mov      x0, x19
006AF1DA0  mov      w1, w20
006AF1DA4  blr      x8
006AF1DA8  mov      x0, x19
006AF1DAC  mov      x1, xzr
006AF1DB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF1DB4  adrp     x21, #0x959f000
006AF1DB8  ldrb     w8, [x21, #0x256]
006AF1DBC  mov      w20, w0
006AF1DC0  cbnz     w8, #0x6af1dd8
006AF1DC4  adrp     x0, #0x8f3d000
006AF1DC8  ldr      x0, [x0, #0x710]
006AF1DCC  bl       #0x382bd14 ; 
006AF1DD0  mov      w8, #1
006AF1DD4  strb     w8, [x21, #0x256]
006AF1DD8  adrp     x8, #0x8f3d000
006AF1DDC  ldr      x8, [x8, #0x710]
006AF1DE0  ldr      x2, [x8]
006AF1DE4  ldrb     w8, [x2, #0x53]
006AF1DE8  tbnz     w8, #5, #0x6af1df4
006AF1DEC  str      w20, [x19, #0x98]
006AF1DF0  b        #0x6af1e04 ; 
006AF1DF4  ldr      x8, [x2, #0x60]
006AF1DF8  mov      x0, x19
006AF1DFC  mov      w1, w20
006AF1E00  blr      x8
006AF1E04  mov      x0, x19
006AF1E08  mov      x1, xzr
006AF1E0C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AF1E10  adrp     x21, #0x959f000
006AF1E14  ldrb     w8, [x21, #0x257]
006AF1E18  mov      x20, x0
006AF1E1C  cbnz     w8, #0x6af1e34
006AF1E20  adrp     x0, #0x8f3d000
006AF1E24  ldr      x0, [x0, #0x720]
006AF1E28  bl       #0x382bd14 ; 
006AF1E2C  mov      w8, #1
006AF1E30  strb     w8, [x21, #0x257]
006AF1E34  adrp     x8, #0x8f3d000
006AF1E38  ldr      x8, [x8, #0x720]
006AF1E3C  ldr      x2, [x8]
006AF1E40  ldrb     w8, [x2, #0x53]
006AF1E44  tbnz     w8, #5, #0x6af1e5c
006AF1E48  str      x20, [x19, #0xa0]!
006AF1E4C  mov      x0, x19
006AF1E50  mov      x1, x20
006AF1E54  bl       #0x382bcb8 ; 
006AF1E58  b        #0x6af1e6c ; 
006AF1E5C  ldr      x8, [x2, #0x60]
006AF1E60  mov      x0, x19
006AF1E64  mov      x1, x20
006AF1E68  blr      x8
006AF1E6C  ldp      x20, x19, [sp, #0x10]
006AF1E70  mov      w0, #1
006AF1E74  ldp      x30, x21, [sp], #0x20
006AF1E78  ret      

