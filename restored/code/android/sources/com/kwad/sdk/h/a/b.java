package com.kwad.sdk.h.a;

import android.text.TextUtils;
import com.kwad.sdk.utils.br;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public String aEZ;
    public String bgG;
    public String bgH;
    public String bgI;
    public long bgJ;
    public boolean bgK;
    public int loadType;
    public int packageType;
    public String packageUrl;
    public String version;

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj != null && getClass() == obj.getClass()) {
            b bVar = (b) obj;
            if (br.isEquals(this.bgG, bVar.bgG) && br.isEquals(this.aEZ, bVar.aEZ) && br.isEquals(this.version, bVar.version)) {
                return true;
            }
        }
        return false;
    }

    public final long Rn() {
        return this.bgJ;
    }

    public final void aS(long j) {
        this.bgJ = j;
    }

    public int hashCode() {
        StringBuilder sbAppend = new StringBuilder().append(this.bgG).append("_").append(this.aEZ).append("_").append(this.version);
        return TextUtils.isEmpty(sbAppend.toString()) ? super.hashCode() : sbAppend.toString().hashCode();
    }

    @Override // com.kwad.sdk.core.response.a.a
    public String toString() {
        return "PackageInfoBean{packageId='" + this.bgG + "', zipFileName='" + this.bgH + "', zipPath='" + this.bgI + "', startDownloadTime=" + this.bgJ + ", packageUrl='" + this.packageUrl + "', version='" + this.version + "', checksum='" + this.aEZ + "', loadType=" + this.loadType + ", packageType=" + this.packageType + ", isPublic=" + this.bgK + '}';
    }

    public final boolean isValid() {
        return (TextUtils.isEmpty(this.bgG) || TextUtils.isEmpty(this.packageUrl) || TextUtils.isEmpty(this.version) || TextUtils.isEmpty(this.bgH)) ? false : true;
    }
}
