"""Recover cctor array literals by exact content hash, preserving metadata offsets."""
from pathlib import Path
import struct,hashlib,json,re
ROOT=Path(__file__).resolve().parents[1]; p=ROOT/'unpacked/apk/assets/bin/Data/Managed/Metadata/global-metadata.dat';b=p.read_bytes();o,l=struct.unpack_from('<II',b,72)
a=(ROOT/'research-data/topics/choices-box-evolution/evidence/LocalModels.Const--.cctor.asm').read_text();targets=set(re.findall(r'Field\$<PrivateImplementationDetails>\.([A-F0-9]{64})',a));hits=[]
for length in [12,16,20,48]:
 for i in range(o,o+l-length+1):
  d=b[i:i+length];h=hashlib.sha256(d).hexdigest().upper()
  if h in targets:hits.append(dict(field_hash=h,metadata_offset=i,bytes_hex=d.hex(),int32=list(struct.unpack('<'+'i'*(length//4),d))))
r=dict(metadata_path=str(p.relative_to(ROOT)),metadata_sha256=hashlib.sha256(b).hexdigest(),metadata_version=struct.unpack_from('<I',b,4)[0],method='Exact SHA-256 match of literal bytes to compiler-generated PrivateImplementationDetails field name; cctor gives allocation length and destination static-field offset.',hits=hits)
(ROOT/'research-data/topics/choices-box-evolution/inputs/native-constant-arrays.json').write_text(json.dumps(r,indent=2)+'\n');print(json.dumps(hits,indent=2))
