package com.kwad.components.core.innerEc.live.g;

import com.kwad.components.core.innerEc.f;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbKwaishopResourceLivePendantInfo;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCKwaishopResourceLivePendantSignalData;
import com.kwad.sdk.utils.br;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d extends a<PbSCKwaishopResourceLivePendantSignalData> {
    protected final com.kwad.components.core.innerEc.live.b.a.b Uj;

    protected abstract void a(com.kwad.components.core.innerEc.live.f.a aVar);

    @Override // com.kwad.components.core.innerEc.live.g.a
    final /* synthetic */ PbSCKwaishopResourceLivePendantSignalData e(byte[] bArr) {
        return h(bArr);
    }

    public d(com.kwad.components.core.innerEc.live.b.a.b bVar) {
        this.Uj = bVar;
    }

    private boolean aM(String str) {
        return br.isEquals(com.kwad.components.core.innerEc.live.i.e.aI(this.Uj.mAdTemplate), str);
    }

    @Override // com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.SCMessageListener
    public int getPayloadType() {
        try {
            return f.rh().getPbPayloadType().getScKwaishopResourceLivePendantSignalData();
        } catch (Exception unused) {
            return 960;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.core.innerEc.live.g.a
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void g(PbSCKwaishopResourceLivePendantSignalData pbSCKwaishopResourceLivePendantSignalData) {
        List<PbKwaishopResourceLivePendantInfo> pendantInfo;
        com.kwad.sdk.core.d.c.d("SCLiveShopStateMessage", "SC_LIVE_SHOP_STATE onMessageReceived");
        if (aM(pbSCKwaishopResourceLivePendantSignalData.getLiveStreamId()) && (pendantInfo = pbSCKwaishopResourceLivePendantSignalData.getPendantInfo()) != null) {
            com.kwad.components.core.innerEc.live.f.a aVar = new com.kwad.components.core.innerEc.live.f.a();
            aVar.liveStreamId = pbSCKwaishopResourceLivePendantSignalData.getLiveStreamId();
            aVar.XB = String.valueOf(pbSCKwaishopResourceLivePendantSignalData.getSellerId());
            ArrayList arrayList = new ArrayList();
            for (PbKwaishopResourceLivePendantInfo pbKwaishopResourceLivePendantInfo : pendantInfo) {
                if (pbKwaishopResourceLivePendantInfo != null) {
                    com.kwad.components.core.innerEc.live.f.b bVar = new com.kwad.components.core.innerEc.live.f.b();
                    bVar.XD = pbKwaishopResourceLivePendantInfo.getAreaCode();
                    bVar.XE = pbKwaishopResourceLivePendantInfo.getPendantResourceId();
                    bVar.XF = pbKwaishopResourceLivePendantInfo.getPendantCode();
                    bVar.action = pbKwaishopResourceLivePendantInfo.getAction();
                    bVar.XG = pbKwaishopResourceLivePendantInfo.getEventData();
                    bVar.XH = pbKwaishopResourceLivePendantInfo.getThroughInfo();
                    bVar.XI = pbKwaishopResourceLivePendantInfo.isNeedServerProcess();
                    bVar.XJ = pbKwaishopResourceLivePendantInfo.isNeedBusinessHandle();
                    bVar.XK = pbKwaishopResourceLivePendantInfo.getCallbackApi();
                    bVar.XL = pbKwaishopResourceLivePendantInfo.isNeedRandomCall();
                    bVar.XM = pbKwaishopResourceLivePendantInfo.getRandomRangeMillis();
                    bVar.XN = pbKwaishopResourceLivePendantInfo.isNeedSignalFallback();
                    bVar.XO = pbKwaishopResourceLivePendantInfo.getCallbackPath();
                    arrayList.add(bVar);
                }
            }
            aVar.XC = arrayList;
            if (arrayList.isEmpty()) {
                return;
            }
            a(aVar);
        }
    }

    private static PbSCKwaishopResourceLivePendantSignalData h(byte[] bArr) {
        return (PbSCKwaishopResourceLivePendantSignalData) f.rh().parseFrom(bArr, PbSCKwaishopResourceLivePendantSignalData.class);
    }
}
