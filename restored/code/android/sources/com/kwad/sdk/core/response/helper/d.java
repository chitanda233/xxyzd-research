package com.kwad.sdk.core.response.helper;

import com.kwad.sdk.core.response.model.AdStyleInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public static long ey(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return 0L;
        }
        return eC(adTemplate).playDetailInfo.detailTopToolBarInfo.callButtonShowTime;
    }

    public static String ez(AdTemplate adTemplate) {
        return adTemplate == null ? "" : eC(adTemplate).playDetailInfo.detailTopToolBarInfo.callButtonDescription;
    }

    public static String eA(AdTemplate adTemplate) {
        return adTemplate == null ? "" : eC(adTemplate).playEndInfo.endTopToolBarInfo.callButtonDescription;
    }

    public static boolean eB(AdTemplate adTemplate) {
        if (adTemplate != null && e.eE(adTemplate)) {
            return eC(adTemplate).slideClick;
        }
        return false;
    }

    private static AdStyleInfo eC(AdTemplate adTemplate) {
        return e.eM(adTemplate).adStyleInfo;
    }

    public static List<String> eD(AdTemplate adTemplate) {
        AdStyleInfo adStyleInfoEC = eC(adTemplate);
        ArrayList arrayList = new ArrayList();
        try {
            Iterator<AdStyleInfo.ExposeTagInfo> it = adStyleInfoEC.extraDisplayInfo.exposeTagInfoList.iterator();
            while (it.hasNext()) {
                arrayList.add(it.next().text);
            }
        } catch (Exception unused) {
        }
        return arrayList;
    }
}
