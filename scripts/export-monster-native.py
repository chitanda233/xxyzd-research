"""Targeted monster-topic native evidence. Requires capstone and pyelftools."""
import importlib.util, json, re, sys
from pathlib import Path
ROOT = Path(__file__).resolve().parents[1]
spec=importlib.util.spec_from_file_location('native',ROOT/'scripts/04_native_evidence.py')
module=importlib.util.module_from_spec(spec);spec.loader.exec_module(module)
n=module.Native()
targets={
 'MissionData':['Deserialize','ReadPos','ReadRect','ReadRects'],
 'BattleWorldContext':['CreateEnemy','CreateCharacterData'],
 'EntityCharacterData':['Init'],
 'EntityCharacter':['InitAI','OnInit','InitAttribute'],
 'BulletData':['Init','SetScaleShape','CreateCircleShape','GetShapeRadius'],
 'EntityBullet':['CheckDead','IsEntityCanHit','FixDeltaPosInLifeRange'],
 'AIStateController':['Init','InitBorn','InitLeave'],
 'WaterfallBattleManager':['CreateTileMonster','CreateTileGroupMonster','CreateRandomMonster','CalRandomMonster','RefreshMonsters'],
}
entities=json.loads((ROOT/'restored/configs/tables/Character_entity.json').read_text())
for e in entities:
 if e['Type'] in (2,3,201):
  ai=(e['WaveAIId'] or e['AIId']).split(',')[0]
  if ai.startswith('AI'):targets[ai]=['InitAttackLoop','SetAIData']
extra=sys.argv[1:]
out=ROOT/'evidence/monster-topic';out.mkdir(exist_ok=True)
metadata=json.loads((ROOT/'restored/code/il2cpp/script.json').read_text())
mp={x['Address']:x.get('Value',x.get('Name')) for k in ['ScriptString','ScriptMetadata','ScriptMetadataMethod'] for x in metadata[k]}
from elftools.elf.elffile import ELFFile
with (ROOT/'unpacked/apk/lib/arm64-v8a/libil2cpp.so').open('rb') as f:
 elf=ELFFile(f);rel={r['r_offset']:r['r_addend'] for sec in elf.iter_sections() if sec['sh_type']=='SHT_RELA' for r in sec.iter_relocations()}
def annotate(text):
 regs={};lines=[]
 for line in text.splitlines():
  a=re.search(r'adrp\s+(x\d+), #0x([\da-f]+)',line)
  b=re.search(r'ldr\s+(x\d+), \[(x\d+)(?:, #0x([\da-f]+))?\]',line)
  if a:regs[a[1]]=int(a[2],16)
  elif b:
   if b[2] in regs:
    adr=regs[b[2]]+int(b[3] or '0',16);name=mp.get(rel.get(adr))
    if name is not None:line+=' ; GLOBAL '+str(name)
   regs.pop(b[1],None)
  else:
   d=re.search(r'^\w+\s+\w+\s+(x\d+),',line)
   if d:regs.pop(d[1],None)
  lines.append(line)
 return '\n'.join(lines)+'\n'
index=[]
for m in n.methods:
 cls,_,method=m['Name'].partition('$$');short=cls.rsplit('.',1)[-1]
 if method in targets.get(short,[]) or any(k in m['Name'] for k in extra):
  filename=re.sub(r'[^\w.-]','_',short+'--'+method)+'-'+hex(m['Address'])+'.asm'
  (out/filename).write_text(annotate(n.render(m)))
  index.append(dict(method=m['Name'],rva=hex(m['Address']),file=filename))
(out/'index.json').write_text(json.dumps(index,ensure_ascii=False,indent=2))
print('Exported',len(index),'targeted methods')
