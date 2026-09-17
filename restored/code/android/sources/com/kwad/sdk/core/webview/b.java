package com.kwad.sdk.core.webview;

import android.content.Context;
import android.text.TextUtils;
import android.view.ViewGroup;
import android.webkit.WebView;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ap;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.widget.g;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    public ViewGroup adZ;
    public WebView adg;
    public g bbV;
    public ap bbW;
    public boolean bbX = true;
    public boolean bbY = true;
    private List<AdTemplate> bbZ = null;
    private AdResultData mAdResultData;
    public JSONObject mReportExtData;
    public int mScreenOrientation;

    public final void a(AdResultData adResultData) {
        this.mAdResultData = adResultData;
    }

    public final AdResultData iF() {
        AdResultData adResultData = this.mAdResultData;
        if (adResultData != null) {
            return adResultData;
        }
        if (this.bbZ == null) {
            return null;
        }
        AdResultData adResultData2 = new AdResultData();
        adResultData2.setAdTemplateList(this.bbZ);
        return adResultData2;
    }

    public final void setAdTemplate(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return;
        }
        ArrayList arrayList = new ArrayList();
        this.bbZ = arrayList;
        arrayList.add(adTemplate);
    }

    public final void setAdTemplateList(List<AdTemplate> list) {
        ArrayList arrayList = new ArrayList(list.size());
        Iterator<AdTemplate> it = list.iterator();
        while (it.hasNext()) {
            arrayList.add(it.next());
        }
        this.bbZ = arrayList;
    }

    public final AdTemplate getAdTemplate() {
        List<AdTemplate> list = this.bbZ;
        if (list != null && list.size() > 0) {
            return this.bbZ.get(0);
        }
        return com.kwad.sdk.core.response.helper.c.r(this.mAdResultData);
    }

    public final List<AdTemplate> PD() {
        List<AdTemplate> list = this.bbZ;
        if (list != null && list.size() > 0) {
            return this.bbZ;
        }
        AdResultData adResultData = this.mAdResultData;
        if (adResultData != null) {
            return adResultData.getAdTemplateList();
        }
        return null;
    }

    public final AdTemplate dS(String str) {
        if (TextUtils.isEmpty(str)) {
            return getAdTemplate();
        }
        List<AdTemplate> listPD = PD();
        if (listPD == null) {
            return null;
        }
        for (AdTemplate adTemplate : listPD) {
            if (br.isEquals(str, String.valueOf(com.kwad.sdk.core.response.helper.e.eW(adTemplate)))) {
                return adTemplate;
            }
        }
        return null;
    }

    public final boolean PE() {
        return PD() == null || PD().size() == 0;
    }

    public final Context getContext() {
        WebView webView = this.adg;
        if (webView == null) {
            return null;
        }
        return webView.getContext();
    }
}
