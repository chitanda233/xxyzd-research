package com.kwad.sdk.core.network.b;

import android.net.Uri;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Log;
import com.kwad.sdk.core.network.i;
import com.kwad.sdk.core.network.j;
import com.kwad.sdk.core.network.k;
import com.kwad.sdk.service.ServiceProvider;
import java.util.Random;

/* JADX INFO: loaded from: classes3.dex */
public final class d implements b {
    private static String aUA = "";
    private static boolean aUu = true;
    public static double aUv = 1.0d;
    private static volatile boolean aUz = false;
    private long aUw = -1;
    private long aUx = -1;
    private long aUy = -1;
    private j aUB = new j();

    private static boolean aC(long j) {
        return j != -1;
    }

    private static boolean aF(long j) {
        return j >= 50;
    }

    @Override // com.kwad.sdk.core.network.b.b
    public final /* synthetic */ b eo(int i) {
        return es(1);
    }

    public d() {
        aUv = new Random().nextDouble();
    }

    private static void eW(String str) {
        if (aUu) {
            com.kwad.sdk.core.d.c.d("NetworkMonitorRecorder", str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: eX, reason: merged with bridge method [inline-methods] */
    public d eR(String str) {
        if (TextUtils.isEmpty(str)) {
            return this;
        }
        this.aUB.url = str;
        if (str.contains("?")) {
            String[] strArrSplit = str.split("\\?");
            if (strArrSplit.length > 0) {
                str = strArrSplit[0];
            }
        }
        if (!TextUtils.isEmpty(str)) {
            eW("url:" + str);
        }
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: eY, reason: merged with bridge method [inline-methods] */
    public d eS(String str) {
        try {
            this.aUB.host = Uri.parse(str).getHost();
            eW("host:" + this.aUB.host);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.e("NetworkMonitorRecorder", Log.getStackTraceString(e));
        }
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: er, reason: merged with bridge method [inline-methods] */
    public d en(int i) {
        this.aUB.httpCode = i;
        eW("http_code:" + i);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: eZ, reason: merged with bridge method [inline-methods] */
    public d eT(String str) {
        this.aUB.errorMsg = str;
        eW(str);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: fa, reason: merged with bridge method [inline-methods] */
    public d eU(String str) {
        this.aUB.aTv = str;
        eW("reqType:" + str);
        fc(com.kwad.sdk.ip.direct.a.Rp());
        MV();
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MO, reason: merged with bridge method [inline-methods] */
    public d MG() {
        this.aUB.aTF = SystemClock.elapsedRealtime();
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MP, reason: merged with bridge method [inline-methods] */
    public d MH() {
        this.aUx = SystemClock.elapsedRealtime();
        eW("this.responseReceiveTime:" + this.aUx);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: aD, reason: merged with bridge method [inline-methods] */
    public d aB(long j) {
        this.aUB.aTL = j;
        eW("responseSize:" + j);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MQ, reason: merged with bridge method [inline-methods] */
    public d MI() {
        if (aC(this.aUw) && aC(this.aUx)) {
            this.aUB.aTM = this.aUx - this.aUw;
            eW("info.waiting_response_cost:" + this.aUB.aTM);
        }
        return this;
    }

    private d aE(long j) {
        this.aUB.aTN = j;
        eW("totalCost:" + j);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: fb, reason: merged with bridge method [inline-methods] */
    public d eV(String str) {
        this.aUB.aTP = str;
        eW("requestId:" + str);
        return this;
    }

    private d es(int i) {
        this.aUB.aTQ = i;
        eW("hasData:" + i);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: et, reason: merged with bridge method [inline-methods] */
    public d ep(int i) {
        this.aUB.result = i;
        eW("result:" + i);
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MR, reason: merged with bridge method [inline-methods] */
    public d MJ() {
        if (aC(this.aUB.aTF)) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            this.aUw = jElapsedRealtime;
            j jVar = this.aUB;
            jVar.aTz = jElapsedRealtime - jVar.aTF;
            if (aC(this.aUB.aTx)) {
                j jVar2 = this.aUB;
                jVar2.aTy = jVar2.aTz - this.aUB.aTx;
            }
            eW("info.request_create_cost:" + this.aUB.aTz);
            eW("info.requestAddParamsCost:" + this.aUB.aTy);
        }
        return this;
    }

    @Override // com.kwad.sdk.core.network.b.b
    public final b MK() {
        if (aC(this.aUB.aTF)) {
            this.aUB.aTx = SystemClock.elapsedRealtime() - this.aUB.aTF;
            eW("info.request_prepare_cost:" + this.aUB.aTx);
        }
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MS, reason: merged with bridge method [inline-methods] */
    public d ML() {
        if (aC(this.aUx)) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            this.aUy = jElapsedRealtime;
            this.aUB.aTK = jElapsedRealtime - this.aUx;
            eW("info.response_parse_cost:" + this.aUB.aTK);
        }
        return this;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.b.b
    /* JADX INFO: renamed from: MT, reason: merged with bridge method [inline-methods] */
    public d MM() {
        if (aC(this.aUy)) {
            this.aUB.aTR = SystemClock.elapsedRealtime() - this.aUy;
            MU();
            eW("info.response_done_cost:" + this.aUB.aTR);
        }
        return this;
    }

    private void MU() {
        j jVar = this.aUB;
        if (jVar == null || jVar.aTQ != 1 || aF(this.aUB.aTR)) {
            return;
        }
        this.aUB.aTR = -1L;
    }

    @Override // com.kwad.sdk.core.network.b.b
    public final b eq(int i) {
        this.aUB.aTT = i;
        if (i != 0) {
            this.aUB.aTw = 1;
        }
        return this;
    }

    private d fc(String str) {
        this.aUB.aTS = str;
        return this;
    }

    private d MV() {
        this.aUB.aTU = (int) com.kwad.sdk.ip.direct.a.Rq();
        this.aUB.aTV = (int) com.kwad.sdk.ip.direct.a.Rr();
        this.aUB.aTW = (int) com.kwad.sdk.ip.direct.a.Rs();
        return this;
    }

    private static boolean c(i iVar) {
        if (TextUtils.isEmpty(iVar.url)) {
            return true;
        }
        String lowerCase = iVar.url.toLowerCase();
        return lowerCase.contains("beta") || lowerCase.contains("test") || lowerCase.contains("staging");
    }

    @Override // com.kwad.sdk.core.network.b.b
    public final void report() {
        if (c((i) this.aUB)) {
            return;
        }
        if (this.aUB.httpCode != 200) {
            MW();
            return;
        }
        long jElapsedRealtime = aC(this.aUB.aTF) ? SystemClock.elapsedRealtime() - this.aUB.aTF : -1L;
        aE(jElapsedRealtime);
        if (jElapsedRealtime > 30000 || jElapsedRealtime <= -1) {
            return;
        }
        k kVar = (k) ServiceProvider.get(k.class);
        if (kVar != null) {
            kVar.a(this.aUB);
        }
        eW("report normal" + this.aUB.toString());
    }

    private void MW() {
        i iVarC = c(this.aUB);
        k kVar = (k) ServiceProvider.get(k.class);
        if (kVar != null) {
            kVar.a(iVarC);
        }
        com.kwad.sdk.core.d.c.d("NetworkMonitorRecorder", "reportError" + iVarC.toJson().toString());
    }

    private static i c(j jVar) {
        i iVar = new i();
        iVar.errorMsg = jVar.errorMsg;
        iVar.host = jVar.host;
        iVar.httpCode = jVar.httpCode;
        iVar.aTv = jVar.aTv;
        iVar.url = jVar.url;
        iVar.aTw = jVar.aTw;
        return iVar;
    }
}
