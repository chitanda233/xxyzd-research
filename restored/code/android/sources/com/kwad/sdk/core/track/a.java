package com.kwad.sdk.core.track;

import android.text.TextUtils;
import com.kwad.components.ad.reward.monitor.FraudVerifyCode;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.export.proxy.AdHttpProxy;
import com.kwad.sdk.h;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ak;
import com.kwad.sdk.utils.ar;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static boolean eA(int i) {
        return i >= 200 && i < 300;
    }

    public static void e(com.kwad.sdk.core.adlog.c.a aVar) {
        AdTemplate adTemplate = aVar.adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        int i = aVar.aKK;
        List<String> listA = a(adTemplate, i, aVar);
        if (ar.R(listA)) {
            return;
        }
        boolean zDE = com.kwad.sdk.core.response.helper.a.dE(adInfoEM);
        boolean zDF = com.kwad.sdk.core.response.helper.a.dF(adInfoEM);
        for (String str : listA) {
            com.kwad.sdk.commercial.i.a.p(adTemplate, i, str);
            if (adTemplate.isCheatingFlow()) {
                com.kwad.sdk.commercial.i.a.o(adTemplate, i, str);
                return;
            }
            if (by.iq(str)) {
                com.kwad.sdk.commercial.i.a.a(adTemplate, i, str, "", FraudVerifyCode.RerwardFraudUnknown, "", 0);
                return;
            }
            HashMap map = null;
            String strA = ak.a(ServiceProvider.getContext(), str, i == 2 ? aVar.ng : null, com.kwad.sdk.core.response.helper.a.aH(e.eM(adTemplate)));
            ak.f(adTemplate, str, strA);
            AdHttpProxy adHttpProxyES = h.ES();
            int i2 = adHttpProxyES instanceof com.kwad.sdk.core.network.c.a ? 2 : 1;
            c.d("AdTrackUtil", "handleTrackUrl useKwaiUA: " + zDE);
            if (zDE) {
                com.kwad.sdk.core.i.c cVarK = com.kwad.sdk.core.i.a.k(zDE, zDF);
                c.d("AdTrackUtil", "handleTrackUrl uaGetter: " + cVarK);
                if (cVarK != null) {
                    map = new HashMap();
                    map.put("User-Agent", cVarK.OL());
                }
            }
            com.kwad.sdk.core.network.c cVarDoGetWithoutResponse = adHttpProxyES.doGetWithoutResponse(strA, map, !zDE);
            if (eA(cVarDoGetWithoutResponse.code)) {
                c.d("AdTrackUtil", "trackUrl request success actionType: " + i);
                com.kwad.sdk.commercial.i.a.a(adTemplate, i, str, cVarDoGetWithoutResponse.code, i2);
            } else {
                com.kwad.sdk.commercial.i.a.a(adTemplate, i, str, strA, com.kwad.sdk.commercial.e.dj(cVarDoGetWithoutResponse.code), cVarDoGetWithoutResponse.aSY, i2);
            }
        }
    }

    private static List<String> a(AdTemplate adTemplate, int i, com.kwad.sdk.core.adlog.c.a aVar) {
        ArrayList arrayList = new ArrayList();
        AdInfo adInfoEM = e.eM(adTemplate);
        List<AdInfo.AdTrackInfo> list = adInfoEM.adTrackInfoList;
        if (ar.R(list)) {
            return arrayList;
        }
        List<String> listA = a(i, aVar, arrayList, adInfoEM, list);
        if (listA != null) {
            return listA;
        }
        for (AdInfo.AdTrackInfo adTrackInfo : list) {
            if (adTrackInfo.type == i && adTrackInfo.urls != null) {
                arrayList.addAll(adTrackInfo.urls);
                break;
            }
        }
        return arrayList;
    }

    private static List<String> a(int i, com.kwad.sdk.core.adlog.c.a aVar, List<String> list, AdInfo adInfo, List<AdInfo.AdTrackInfo> list2) {
        int iOptInt;
        if (i != 402 || !com.kwad.sdk.core.response.helper.a.bu(adInfo)) {
            return null;
        }
        try {
            if (!TextUtils.isEmpty(aVar.QQ)) {
                iOptInt = new JSONObject(aVar.QQ).optInt("photoPlaySecond");
            } else {
                iOptInt = aVar.aMf;
            }
            JSONObject jSONObject = new JSONObject(adInfo.adBaseInfo.videoPlayedNSConfig);
            for (AdInfo.AdTrackInfo adTrackInfo : list2) {
                if (adTrackInfo.type == jSONObject.optInt(String.valueOf(iOptInt)) && adTrackInfo.urls != null) {
                    list.addAll(adTrackInfo.urls);
                    break;
                }
            }
        } catch (Throwable unused) {
        }
        return list;
    }
}
