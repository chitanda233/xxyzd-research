"""Targeted native export for the choices / box / evolution topic; no global re-export."""
import importlib.util,json,re,sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[1]
spec=importlib.util.spec_from_file_location('native', ROOT/'scripts/04_native_evidence.py'); mod=importlib.util.module_from_spec(spec); spec.loader.exec_module(mod)
from elftools.elf.elffile import ELFFile
n=mod.Native(); meta=json.loads((ROOT/'restored/code/il2cpp/script.json').read_text()); mp={x['Address']:x.get('Value',x.get('Name')) for k in ['ScriptString','ScriptMetadata','ScriptMetadataMethod'] for x in meta[k]}
with (ROOT/'unpacked/apk/lib/arm64-v8a/libil2cpp.so').open('rb') as f:
 e=ELFFile(f); reloc={r['r_offset']:r['r_addend'] for sec in e.iter_sections() if sec['sh_type']=='SHT_RELA' for r in sec.iter_relocations()}
out=ROOT/'research-data/topics/choices-box-evolution/evidence';out.mkdir(parents=True,exist_ok=True)
for key in sys.argv[1:]:
 methods=[m for m in n.methods if m['Name']==key or m['Name'].split('$$')[0]==key]
 if not methods:print('NOT FOUND',key)
 for m in methods:
  regs={};lines=[]
  for line in n.render(m).splitlines():
   a=re.search(r'adrp\s+(x\d+), #0x([\da-f]+)',line);b=re.search(r'ldr\s+(x\d+), \[(x\d+)(?:, #0x([\da-f]+))?\]',line)
   if a:regs[a[1]]=int(a[2],16)
   elif b:
    if b[2] in regs:
     target=reloc.get(regs[b[2]]+int(b[3] or '0',16));name=mp.get(target)
     if name is not None:line+=' ; GLOBAL '+str(name)+' @ '+hex(target)
    regs.pop(b[1],None)
   else:
    d=re.search(r'^\w+\s+\w+\s+(x\d+),',line)
    if d:regs.pop(d[1],None)
   lines.append(line)
  name=m['Name'].replace('HotFix.BattleLogic.','').replace('$$','--').replace('/','_')
  if sum(x['Name']==m['Name'] for x in methods)>1:name+='--'+hex(m['Address'])
  name+='.asm'
  (out/name).write_text('\n'.join(lines)+'\n')
 print(key,len(methods))
