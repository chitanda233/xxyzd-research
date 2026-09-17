package com.kwad.components.core.request;

import android.text.TextUtils;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.kwad.components.core.request.model.ImpInfo;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.internal.api.AdLabelImpl;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ab;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.t;
import java.util.Collection;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.core.network.d {
    private static boolean ajF = true;
    ImpInfo abv;
    private int ajE;

    @Override // com.kwad.sdk.core.network.d
    public boolean needAppList() {
        return true;
    }

    public a(ImpInfo impInfo) {
        this(impInfo, null);
    }

    private a(ImpInfo impInfo, com.kwad.components.core.request.model.c cVar) {
        this(impInfo, null, false, null);
    }

    public a(com.kwad.components.core.request.model.a aVar) {
        this(aVar.abv, aVar.ajO, aVar.ajP, aVar.ajR);
        this.ajE = aVar.ajQ ? 1 : 0;
    }

    public a(ImpInfo impInfo, List<String> list, boolean z, com.kwad.components.core.request.model.c cVar) {
        super(c(impInfo), impInfo.adScene);
        this.abv = impInfo;
        AdLabelImpl adLabelFromAdScene = impInfo.getAdLabelFromAdScene();
        if (adLabelFromAdScene != null && !adLabelFromAdScene.isAdLabelAppInfoInValid()) {
            a(com.kwad.sdk.core.request.model.a.Nz(), adLabelFromAdScene);
        }
        JSONArray jSONArray = new JSONArray();
        ac.a(jSONArray, impInfo.toJson());
        putBody("impInfo", jSONArray);
        putBody("universePhotoInfo", cVar);
        int i = this.ajE;
        if (i > 0) {
            putBody("calledUnionType", i);
        }
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        String strIP = TextUtils.isEmpty("") ? ((DevelopMangerComponents) com.kwad.sdk.components.d.f(DevelopMangerComponents.class)).IP() : "";
        if (!TextUtils.isEmpty(strIP)) {
            putBody("universeDebugParam", strIP);
        }
        String strD = d(impInfo);
        if (!TextUtils.isEmpty(strD)) {
            putBody("sdkDebugReqInfo", strD);
        }
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        if (list != null) {
            putBody("preloadIdList", new JSONArray((Collection) list));
            putBody("preloadCheck", z);
        }
        putBody("appTag", ai.Vx());
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        String rewardCallbackExtraByKey = this.abv.getRewardCallbackExtraByKey("thirdUserId");
        com.kwad.sdk.core.request.model.g gVarNG = com.kwad.sdk.core.request.model.g.NG();
        try {
            String strF = ai.f(ServiceProvider.getContext(), false);
            if (!TextUtils.isEmpty(strF)) {
                InnerEcLocalLoginInfo innerEcLocalLoginInfo = new InnerEcLocalLoginInfo();
                innerEcLocalLoginInfo.parseJson(new JSONObject(strF));
                long jCurrentTimeMillis = System.currentTimeMillis();
                if (!TextUtils.isEmpty(innerEcLocalLoginInfo.serviceToken) && jCurrentTimeMillis < innerEcLocalLoginInfo.expire) {
                    gVarNG.fi(innerEcLocalLoginInfo.serviceToken);
                }
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
        if (rewardCallbackExtraByKey != null) {
            gVarNG.fg(rewardCallbackExtraByKey);
        }
        if (adLabelFromAdScene != null && !adLabelFromAdScene.isUserInfoVaild()) {
            a(gVarNG, adLabelFromAdScene);
        }
        putBody("userInfo", gVarNG);
        if (com.kwad.components.ad.f.a.oU.booleanValue()) {
            try {
                com.kwad.sdk.components.a aVar = (com.kwad.sdk.components.a) com.kwad.sdk.components.d.f(com.kwad.sdk.components.a.class);
                if (aVar != null) {
                    putBody("adBrowseParam", aVar.IO());
                }
            } catch (Throwable unused) {
            }
        }
    }

    private static void a(com.kwad.sdk.core.request.model.g gVar, AdLabelImpl adLabelImpl) {
        if (adLabelImpl.thirdAge != 0) {
            gVar.thirdAge = adLabelImpl.thirdAge;
        }
        if (adLabelImpl.thirdGender != 0) {
            gVar.thirdGender = adLabelImpl.thirdGender;
        }
        if (TextUtils.isEmpty(adLabelImpl.thirdInterest)) {
            return;
        }
        gVar.thirdInterest = adLabelImpl.thirdInterest;
    }

    private void a(JSONObject jSONObject, AdLabelImpl adLabelImpl) {
        JSONObject jSONObject2 = new JSONObject();
        if (!TextUtils.isEmpty(adLabelImpl.prevTitle)) {
            ac.putValue(jSONObject2, "prevTitle", adLabelImpl.prevTitle);
        }
        if (!TextUtils.isEmpty(adLabelImpl.postTitle)) {
            ac.putValue(jSONObject2, "postTitle", adLabelImpl.postTitle);
        }
        if (!TextUtils.isEmpty(adLabelImpl.historyTitle)) {
            ac.putValue(jSONObject2, "historyTitle", adLabelImpl.historyTitle);
        }
        if (!TextUtils.isEmpty(adLabelImpl.channel)) {
            ac.putValue(jSONObject2, "channel", adLabelImpl.channel);
        }
        ac.putValue(jSONObject, IAdInterListener.AdProdType.PRODUCT_CONTENT, jSONObject2);
        putBody("appInfo", jSONObject);
    }

    private static int c(ImpInfo impInfo) {
        try {
            return impInfo.adScene.getScreenOrientation();
        } catch (Throwable unused) {
            return 0;
        }
    }

    public final void bI(int i) {
        this.ajE = i;
    }

    public final int getAdNum() {
        return this.abv.adScene.getAdNum();
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public String getUrl() {
        if (com.kwad.components.ad.f.a.oU.booleanValue()) {
            try {
                if (((com.kwad.sdk.components.a) com.kwad.sdk.components.d.f(com.kwad.sdk.components.a.class)) != null) {
                    return com.kwad.sdk.i.Fn();
                }
            } catch (Throwable unused) {
            }
        }
        return com.kwad.sdk.i.EW();
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public SceneImpl getScene() {
        ImpInfo impInfo = this.abv;
        if (impInfo != null) {
            return impInfo.adScene;
        }
        return null;
    }

    private static String d(ImpInfo impInfo) {
        com.kwad.sdk.service.a.f fVar;
        if (ajF && (fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)) != null) {
            try {
                return (String) ab.callMethodOrThrow(Class.forName("com.kwad.devTools.PosConfigFetcher").newInstance(), "getConfigParamByPosId", Long.valueOf(impInfo.adScene.getPosId()), fVar.getContext());
            } catch (Exception unused) {
                ajF = false;
            }
        }
        return "";
    }

    @Override // com.kwad.sdk.core.network.b
    public void onCreate() {
        t.ct(true);
        b.wc().wd();
        super.onCreate();
    }
}
