package com.sigmob.sdk.base.network;

import com.byazt.nys.PluginConstants;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.SigmobRequestUtil;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.windad.WindAdError;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3238a = "f";
    private static final List<String> b = new ArrayList<String>() { // from class: com.sigmob.sdk.base.network.f.1
        {
            add("998");
        }
    };

    public interface a {
        void a(int error, String message, String requestId, LoadAdRequest loadAdRequest);

        void a(List<BaseAdUnit> adUnit, LoadAdRequest loadAdRequest);
    }

    public static void a(LoadAdRequest loadAdRequest, a listener) {
        k.a(3, f3238a, "load", loadAdRequest, (Map<String, Object>) null);
        if (Networking.getSigRequestQueue() == null) {
            a(listener, WindAdError.ERROR_SIGMOB_NETWORK.getErrorCode(), "request queue is null.", null, loadAdRequest);
            return;
        }
        try {
            String bidToken = loadAdRequest.getBidToken();
            String placementId = loadAdRequest.getPlacementId();
            String adx_id = loadAdRequest.getAdx_id();
            boolean z = s.b(adx_id) && b.contains(adx_id);
            o oVarA = o.a();
            String strC = loadAdRequest.getAdType() == 5 ? oVarA.c(z) : oVarA.a(z);
            try {
                if (s.b(bidToken)) {
                    strC = oVarA.b(z);
                }
            } catch (Throwable th) {
                k.f(f3238a, "loadAd: placementId = " + placementId + ", error = " + th.getMessage(), new Object[0]);
            }
            if (s.a((CharSequence) strC)) {
                a(listener, WindAdError.ERROR_SIGMOB_BAD_REQUEST.getErrorCode(), WindAdError.ERROR_SIGMOB_BAD_REQUEST.getMessage(), null, loadAdRequest);
            } else if (SigmobRequestUtil.isConnection(new URL(strC).getHost())) {
                Networking.getSigRequestQueue().add(new com.sigmob.sdk.base.network.a(strC, loadAdRequest, listener));
            } else {
                a(listener, WindAdError.ERROR_SIGMOB_NETWORK.getErrorCode(), "network is disconnection.", null, loadAdRequest);
            }
        } catch (Throwable th2) {
            a(listener, WindAdError.ERROR_SIGMOB_NETWORK.getErrorCode(), th2.getMessage(), null, loadAdRequest);
        }
    }

    public static void a(a listener, int errCode, String errorMsg, String requestId, LoadAdRequest loadAdRequest) {
        HashMap map = new HashMap();
        map.put(PluginConstants.KEY_ERROR_CODE, Integer.valueOf(errCode));
        map.put("msg", errorMsg);
        k.a(6, f3238a, "load(failure)", loadAdRequest, map);
        if (listener == null) {
            return;
        }
        listener.a(errCode, errorMsg, requestId, loadAdRequest);
        com.sigmob.sdk.manager.d.a().a(loadAdRequest);
    }

    public static void a(a listener, List<BaseAdUnit> adUnits, LoadAdRequest loadAdRequest) {
        if (com.sigmob.sdk.base.utils.f.b(adUnits)) {
            Iterator<BaseAdUnit> it = adUnits.iterator();
            while (it.hasNext()) {
                k.a(3, f3238a, com.alipay.sdk.m.n.c.d, it.next(), (Map<String, Object>) null);
            }
        }
        if (listener == null) {
            return;
        }
        listener.a(adUnits, loadAdRequest);
        com.sigmob.sdk.manager.d.a().a(loadAdRequest);
    }
}
