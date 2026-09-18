from pathlib import Path
import sys, json, bisect, re
ROOT = Path(__file__).resolve().parents[1]
sys.path.insert(0, str(ROOT / 'tools/python'))
from capstone import Cs, CS_ARCH_ARM64, CS_MODE_ARM
from elftools.elf.elffile import ELFFile

class Native:
    def __init__(self):
        self.methods = json.loads((ROOT / 'restored/code/il2cpp/script.json').read_text())['ScriptMethod']
        self.by_address = {}
        for m in self.methods:
            self.by_address.setdefault(m['Address'], []).append(m['Name'])
        self.addresses = sorted(self.by_address)
        path = ROOT / 'unpacked/apk/lib/arm64-v8a/libil2cpp.so'
        self.binary = path.read_bytes()
        with path.open('rb') as f:
            self.segments = [(s['p_vaddr'], s['p_offset'], s['p_filesz']) for s in ELFFile(f).iter_segments() if s['p_type'] == 'PT_LOAD']
        self.cs = Cs(CS_ARCH_ARM64, CS_MODE_ARM)

    def disassemble(self, address, limit=16000):
        pos = bisect.bisect_right(self.addresses, address)
        end = self.addresses[pos] if pos < len(self.addresses) else address + 4096
        length = min(end - address, limit)
        for va, off, size in self.segments:
            if va <= address < va + size:
                data = self.binary[off+address-va:off+address-va+length]
                return list(self.cs.disasm(data, address))
        return []

    def render(self, method):
        lines = [f'; {method["Name"]}', f'; RVA 0x{method["Address"]:X}; native ARM64 evidence, not reconstructed C#', '; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.']
        for ins in self.disassemble(method['Address']):
            annotation = ''
            if ins.mnemonic in ('bl', 'b') and ins.op_str.startswith('#0x'):
                target = int(ins.op_str[1:], 16)
                annotation = ' ; ' + ' | '.join(self.by_address.get(target, []))
            lines.append(f'{ins.address:09X}  {ins.mnemonic:8s} {ins.op_str}{annotation}')
        return '\n'.join(lines) + '\n\n'

def main():
    native = Native()
    folder = ROOT / 'restored/code/native-evidence'
    folder.mkdir(parents=True, exist_ok=True)
    names = ['BaseLocalBean', 'CharacterComponentOnHit', 'WaterfallBattleManager', 'BaseSurvivalBattleManager', 'SinglePlayerBattleManager', 'WaterfallStateSelectSkill', 'WaterfallStateSpecialSelectSkill', 'BeeMonsterRefresher', 'BeeMonsterCreator', 'NormalSkillCreator', 'SinglePlayerSkillCreator', 'HeroSkillCreator', 'HeroComponentRandomSkill', 'DankeSkillCreator', 'HeroComponentExp', 'ExpAnimProcessor', 'WeightRandom', 'MainDropManager', 'CharacterComponentBuff']
    selected = [m for m in native.methods if any(n in m['Name'].split('$$')[0] for n in names) or ('LocalModels.Bean.' in m['Name'] and m['Name'].endswith('$$readImpl'))]
    groups = {}
    for m in selected:
        group = m['Name'].split('$$')[0]
        group = re.sub(r'[^\w.-]', '_', group)[:140]
        groups.setdefault(group, []).append(m)
    for group, methods in groups.items():
        (folder / (group+'.asm')).write_text(''.join(native.render(m) for m in methods), encoding='utf-8', newline="\n")
    (ROOT / 'indexes/native-evidence.json').write_text(json.dumps({'selected_methods': len(selected), 'files':len(groups), 'selection':names, 'note':'Includes LocalModels.Bean readImpl methods for binary table validation.'},indent=2), encoding='utf-8', newline="\n")
    print(f'Exported {len(selected)} native methods in {len(groups)} files')

if __name__ == '__main__':
    main()
