package com.kwad.components.ad.reward.model;

import android.text.TextUtils;
import com.kwad.components.ad.reward.n.r;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.CouponInfo;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private String liveStartTime;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private String originPrice;
    private int playableStyle;
    private String price;
    private String tL;
    private String tM;
    private String title;
    private List<String> vG;
    private String vH;
    private String vI;
    private String vJ;
    private boolean vK;
    private String vL;
    private String vM = "查看详情";
    private String vN = "立即预约";
    private List<String> vO;
    private AdTemplate vP;

    public static a R(AdTemplate adTemplate) {
        CouponInfo firstCouponList;
        if (adTemplate == null) {
            return null;
        }
        AdInfo adInfoEM = e.eM(adTemplate);
        AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfoEM);
        a aVar = new a();
        String name = adProductInfoDc.getName();
        aVar.title = name;
        if (TextUtils.isEmpty(name)) {
            aVar.title = com.kwad.sdk.core.response.helper.a.aD(adInfoEM);
        }
        aVar.tL = adProductInfoDc.getIcon();
        aVar.tM = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
        aVar.price = adProductInfoDc.getPrice();
        aVar.originPrice = adProductInfoDc.getOriginPrice();
        if (!adProductInfoDc.isCouponListEmpty() && (firstCouponList = adProductInfoDc.getFirstCouponList()) != null) {
            aVar.S(CouponInfo.jinniuFormatCoupon(firstCouponList));
            aVar.R(firstCouponList.getFormattedJinniuPrefix());
        }
        return aVar;
    }

    public static a a(r rVar, boolean z) {
        AdTemplate adTemplate;
        if (rVar == null || (adTemplate = rVar.getAdTemplate()) == null) {
            return null;
        }
        AdInfo adInfoEM = e.eM(adTemplate);
        a aVar = new a();
        aVar.title = com.kwad.sdk.core.response.helper.a.cs(adInfoEM);
        aVar.tL = com.kwad.sdk.core.response.helper.a.cv(adInfoEM);
        aVar.tM = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
        aVar.vG = com.kwad.sdk.core.response.helper.d.eD(adTemplate);
        aVar.vH = com.kwad.sdk.core.response.helper.a.aK(adInfoEM);
        aVar.playableStyle = e.n(adTemplate, z);
        aVar.vP = adTemplate;
        aVar.mApkDownloadHelper = rVar.it();
        return aVar;
    }

    public static a S(AdTemplate adTemplate) {
        AdMatrixInfo.MerchantLiveReservationInfo merchantLiveReservationInfoDP = com.kwad.sdk.core.response.helper.b.dP(adTemplate);
        a aVar = new a();
        aVar.tL = merchantLiveReservationInfoDP.userHeadUrl;
        aVar.liveStartTime = merchantLiveReservationInfoDP.liveStartTime;
        aVar.title = merchantLiveReservationInfoDP.title;
        aVar.vK = merchantLiveReservationInfoDP.needShowSubscriberCount();
        aVar.vL = merchantLiveReservationInfoDP.getFormattedLiveSubscribeCount();
        aVar.vO = merchantLiveReservationInfoDP.bookUserUrlList;
        aVar.vM = merchantLiveReservationInfoDP.playEndCard.detailBtnTitle;
        aVar.vN = merchantLiveReservationInfoDP.playEndCard.reservationBtnTitle;
        aVar.vP = adTemplate;
        return aVar;
    }

    public final String hy() {
        return this.tL;
    }

    public final String getTitle() {
        return this.title;
    }

    public final String hz() {
        return this.tM;
    }

    public final String getPrice() {
        return this.price;
    }

    public final String getOriginPrice() {
        return this.originPrice;
    }

    public final String iq() {
        return this.vJ;
    }

    public final String ir() {
        return this.vI;
    }

    private void R(String str) {
        this.vI = str;
    }

    private void S(String str) {
        this.vJ = str;
    }

    public final AdTemplate is() {
        return this.vP;
    }

    public final com.kwad.components.core.e.d.d it() {
        return this.mApkDownloadHelper;
    }

    public final List<String> iu() {
        return this.vG;
    }

    public final boolean iv() {
        List<String> list = this.vG;
        return list == null || list.size() == 0;
    }

    public final int iw() {
        return this.playableStyle;
    }

    public final String ix() {
        return this.vL;
    }

    public final String iy() {
        return this.vN;
    }

    public final boolean iz() {
        return this.vK;
    }

    public final List<String> iA() {
        return this.vO;
    }

    public final String iB() {
        return this.liveStartTime;
    }
}
