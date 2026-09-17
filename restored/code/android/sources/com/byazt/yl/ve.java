package com.byazt.yl;

import android.app.Activity;
import android.app.Dialog;
import android.graphics.Bitmap;
import android.graphics.Rect;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.ImageView;
import com.byazt.fb.uj;
import com.byazt.me.da;
import com.byazt.me.i;
import com.byazt.me.x;
import com.byazt.nc.sp;
import com.byazt.nc.t;
import com.byazt.nr.m;
import com.byazt.vx.my;
import com.byazt.zh.n;
import com.byazt.zq.a;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bykv.vk.openvk.api.proto.PluginValueSet;
import com.bytedance.gromore.R;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_MODULE_NAME, 54})
public abstract class ve extends uj implements Comparable<ve> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.byazt.fy.c f1585a;
    public String az;
    public int b;
    public double bx;
    public com.byazt.me.tt c;
    public String cf;
    public String cu;
    public String d;
    public String da;
    public boolean dz;
    public long eo;
    public int f;
    public int g;
    public String gt;
    public int gu;
    public String gx;
    public String gy;
    public String h;
    public String hj;
    public int hq;
    public String i;
    public String ij;
    public int ir;
    public c is;
    public int iu;
    public String j;
    public boolean kp;
    public String kz;
    public int l;
    public int lo;
    public String lr;
    public String lt;
    public String m;
    public String ma;
    public boolean md;
    public boolean mm;
    public i n;
    public Map<String, Object> nb;
    public String nt;
    public String nu;
    public String or;
    public String p;
    public double pf;
    public volatile boolean pn;
    public String pu;
    public Map<String, String> qp;
    public String qy;
    public double rh;
    public double rl;
    public int s;
    public String sl;
    public a sp;
    public int sv;
    public int t;
    public String tk;
    public String to;
    public x tt;
    public int u;
    public n uj;
    public com.byazt.zh.tt ve;
    public String vi;
    public long vp;
    public com.byazt.dhf.c w;
    public String x;
    public String xd;
    public int y;
    public volatile boolean yo;
    public int yp;
    public boolean yv;
    public int z;
    public String zb;
    public int zm;
    public List<String> my = new ArrayList();
    public int gr = -1;
    public int aw = 1;
    public int ic = 1;
    public int hd = 1;
    public int bm = 1;
    public volatile boolean q = false;
    public volatile boolean kk = false;
    public volatile boolean tx = false;
    public volatile boolean v = false;
    public final Map<String, Object> os = new my();
    public boolean oz = false;
    public boolean r = false;
    public boolean yf = false;
    public String ny = "1";
    public Map<String, Object> mq = new HashMap();
    public Map<String, Object> jt = new ConcurrentHashMap();

    public interface c {
        void c();

        void c(ve veVar);
    }

    public boolean adnHasAdVideoCachedApi() {
        return false;
    }

    @Override // com.byazt.fb.uj
    public <T> T applyFunction(int i, PluginValueSet pluginValueSet, Class<T> cls) {
        return null;
    }

    public void bidLoseNotify(Map<String, Object> map) {
    }

    public void bidWinNotify(Map<String, Object> map) {
    }

    public void cancelDownload() {
    }

    public void dislikeClick(String str, Map<String, Object> map) {
    }

    public long getAdId() {
        return 0L;
    }

    public String getAdLifecycleId() {
        return null;
    }

    public Bitmap getAdLogo() {
        return null;
    }

    public View getAdView() {
        return null;
    }

    public int getAppCommentNum() {
        return 0;
    }

    public long getCreativeId() {
        return 0L;
    }

    public sp getDislikeDialog(Activity activity) {
        return null;
    }

    public sp getDislikeDialog(Dialog dialog, Integer[] numArr) {
        return null;
    }

    public com.byazt.nc.uj getDislikeInfo() {
        return null;
    }

    public int getDownloadStatus() {
        return -1;
    }

    public com.byazt.nc.n getDownloadStatusController() {
        return null;
    }

    public com.byazt.me.n getGMNativeCustomVideoReporter() {
        return null;
    }

    public int[] getMinWindowSize() {
        return null;
    }

    public String getReqId() {
        return null;
    }

    public Bitmap getSplashBitMap() {
        return null;
    }

    public View getSplashCardView() {
        return null;
    }

    public t getVideoCoverImage() {
        return null;
    }

    public double getVideoDuration() {
        return 0.0d;
    }

    public String getVideoUrl() {
        return null;
    }

    public View getVideoView() {
        return null;
    }

    public abstract boolean hasDestroyed();

    public boolean hasDislike() {
        return false;
    }

    public void hideSkipBtn() {
    }

    public void hideSkipButton() {
    }

    public boolean isAdnPreload() {
        return false;
    }

    public void onPause() {
    }

    public void onResume() {
    }

    public void pauseAppDownload() {
    }

    public void render() {
    }

    public void resumeAppDownload() {
    }

    public void setActivityForDownloadApp(Activity activity) {
    }

    public void setAdInteractionListener(com.byazt.ocd.tt ttVar) {
    }

    public void setCanInterruptVideoPlay(boolean z) {
    }

    public void setDislikeDialog(Dialog dialog, Integer[] numArr) {
    }

    public void setDownloadListener(com.byazt.ocd.ve veVar) {
    }

    public void setDrawVideoListener(com.byazt.uz.c cVar) {
    }

    public void setPauseIcon(Bitmap bitmap, int i) {
    }

    public void setRewardAdPlayAgainController(Object obj) {
    }

    public void setSlideIntervalTime(int i) {
    }

    public void setVideoAdListener(com.byazt.ft.ve veVar) {
    }

    public void showAd(Activity activity, Object obj, String str) {
    }

    public void showMinWindow(Rect rect, a aVar) {
    }

    public void showSplashAd(ViewGroup viewGroup) {
    }

    public void showSplashCardView(ViewGroup viewGroup, Activity activity) {
    }

    public void splashMinWindowAnimationFinish() {
    }

    public void unregisterView() {
    }

    public void uploadDislikeEvent(String str) {
    }

    public void setOriginPrimeRit(String str) {
        this.ma = str;
    }

    public String getOriginPrimeRit() {
        return this.ma;
    }

    public void setUseFromCache(boolean z) {
        this.dz = z;
    }

    public boolean isUseFromCache() {
        return this.dz;
    }

    public void setOriginLinkId(String str) {
        this.j = str;
    }

    public String getOriginLinkId() {
        return this.j;
    }

    public void setIsRefresh(int i) {
        this.iu = i;
    }

    public int getIsRefresh() {
        return this.iu;
    }

    public int getSupportRender() {
        return this.y;
    }

    public void setSupportRender(int i) {
        this.y = i;
    }

    public void setIfReuseAds(int i) {
        this.s = i;
    }

    public int getIfReuseAds() {
        return this.s;
    }

    public boolean isIsCallback() {
        return this.r;
    }

    public void setIsCallback(boolean z) {
        this.r = z;
    }

    public boolean isTimeoutFill() {
        return this.oz;
    }

    public void setTimeoutFill(boolean z) {
        this.oz = z;
    }

    public void setMediaExtraInfo(Map<String, Object> map) {
        if (map != null) {
            this.os.putAll(map);
        }
    }

    public Map<String, Object> getMediaExtraInfo() {
        return this.os;
    }

    public boolean isShowRepeatOnce() {
        if (this.q) {
            return true;
        }
        this.q = true;
        return false;
    }

    public boolean isShowListenRepeatOnce() {
        if (this.kk) {
            return true;
        }
        this.kk = true;
        return false;
    }

    public boolean isClickListenRepeatOnce() {
        if (this.tx) {
            return true;
        }
        this.tx = true;
        return false;
    }

    public boolean isClickListenRepeatPlayAgainOnce() {
        if (this.v) {
            return true;
        }
        this.v = true;
        return false;
    }

    public int getPricingType() {
        return this.b;
    }

    public void setPricingType(int i) {
        this.b = i;
    }

    public void setUseCustomVideo(boolean z) {
        this.kp = z;
    }

    public boolean isUseCustomVideo() {
        return this.kp;
    }

    public String getWinCallback() {
        return this.to;
    }

    public void setWinCallback(String str) {
        this.to = str;
    }

    public String getFailCallback() {
        return this.tk;
    }

    public void setFailCallback(String str) {
        this.tk = str;
    }

    public String getAid() {
        return this.pu;
    }

    public void setAid(String str) {
        this.pu = str;
    }

    public String getAdExtra() {
        return this.lt;
    }

    public void setAdExtra(String str) {
        this.lt = str;
    }

    public int getSubAdType() {
        return this.lo;
    }

    public void setSubAdType(int i) {
        this.lo = i;
    }

    public int getOriginType() {
        return this.l;
    }

    public void setOriginType(int i) {
        this.l = i;
    }

    public void setLinkIdFromRealReq(String str) {
        this.lr = str;
    }

    public void setMediationRitReqTypeFromRealReq(int i) {
        this.hd = i;
    }

    public void setMediationRitReqTypeSrcFromRealReq(int i) {
        this.bm = i;
    }

    public int getMediationRitReqType(String str) {
        if (TextUtils.equals(str, this.lr)) {
            return this.hd;
        }
        return this.aw;
    }

    public void setMediationRitReqType(int i) {
        this.aw = i;
    }

    public int getMediationRitReqTypeSrc(String str) {
        if (TextUtils.equals(str, this.lr)) {
            return this.bm;
        }
        return this.ic;
    }

    public void setMediationRitReqTypeSrc(int i) {
        this.ic = i;
    }

    public String getRegUrl() {
        return this.ij;
    }

    public void setRegUrl(String str) {
        this.ij = str;
    }

    public String getRegNumber() {
        return this.az;
    }

    public void setRegNumber(String str) {
        this.az = str;
    }

    public String getFunctionDescUrl() {
        return this.cf;
    }

    public void setFunctionDescUrl(String str) {
        this.cf = str;
    }

    public void putExtraMsg(String str, Object obj) {
        if (TextUtils.isEmpty(str) || obj == null) {
            return;
        }
        this.mq.put(str, obj);
    }

    public void putExtraMsg(Map<String, Object> map) {
        if (map == null || map.size() <= 0) {
            return;
        }
        this.mq.putAll(map);
    }

    public final Map<String, Object> getExtraMsg() {
        return this.mq;
    }

    public String getErrorMsg() {
        return this.vi;
    }

    public void setErrorMsg(String str) {
        this.vi = str;
    }

    public String getLevelTag() {
        return this.kz;
    }

    public void setLevelTag(String str) {
        this.kz = str;
    }

    public boolean isHasShown() {
        return this.pn;
    }

    public void setHasShown(boolean z) {
        this.pn = z;
    }

    public boolean isHasShowCallback() {
        return this.yo;
    }

    public void setHasShowCallback(boolean z) {
        this.yo = z;
    }

    public final void setFillTime(long j) {
        if (this.vp == 0) {
            this.vp = j;
        }
    }

    public final long getFillTime() {
        return this.vp;
    }

    public Map<String, Object> getEventMap() {
        return this.jt;
    }

    public void putEventParam(String str, Object obj) {
        if (TextUtils.isEmpty(str) || obj == null) {
            return;
        }
        this.jt.put(str, obj);
    }

    public void putEventParams(Map<String, Object> map) {
        if (map == null || map.size() <= 0) {
            return;
        }
        this.jt.putAll(map);
    }

    public void setExchangeRate(String str) {
        this.ny = str;
    }

    public String getExchangeRate() {
        return this.ny;
    }

    public void setAdNetWorkName(String str) {
        this.gx = str;
    }

    public String getAdNetWorkName() {
        return this.gx;
    }

    public void setCustomAdNetWorkName(String str) {
        this.gy = str;
    }

    public String getCustomAdNetWorkName() {
        return this.gy;
    }

    public String getAdnName() {
        return TextUtils.isEmpty(this.gx) ? this.gy : this.gx;
    }

    public void setSdkVersion(String str) {
        this.nt = str;
    }

    public String getSdkVersion() {
        return this.nt;
    }

    public void setExpressAd(boolean z) {
        this.yv = z;
    }

    public boolean isExpressAd() {
        return this.yv;
    }

    public void setImageMode(int i) {
        this.gu = i;
    }

    public void setInteractionType(int i) {
        this.gr = i;
    }

    public int getInteractionType() {
        return this.gr;
    }

    public int getImageMode() {
        return this.gu;
    }

    @Deprecated
    public int getSdkNum() {
        return this.hq;
    }

    public int getAdNetworkPlatformId() {
        return this.hq;
    }

    public void setSdkNum(int i) {
        this.hq = i;
    }

    public void setRit(String str) {
        this.hj = str;
    }

    public String getAdNetworkSlotId() {
        return this.xd;
    }

    public void setAdNetworkSlotId(String str) {
        this.xd = str;
    }

    public String getStore() {
        return this.p;
    }

    public void setStore(String str) {
        this.p = str;
    }

    public boolean getIsAppDownload() {
        return this.md;
    }

    public void setIsAppDownload(boolean z) {
        this.md = z;
    }

    public boolean hasAppInfo() {
        if (!TextUtils.isEmpty(this.h) || !TextUtils.isEmpty(this.d) || this.eo > 0 || !TextUtils.isEmpty(this.zb)) {
            return true;
        }
        Map<String, String> map = this.qp;
        return ((map == null || map.size() <= 0) && TextUtils.isEmpty(this.or) && TextUtils.isEmpty(this.cu) && TextUtils.isEmpty(this.cf)) ? false : true;
    }

    public String getAppName() {
        return this.h;
    }

    public void setAppName(String str) {
        this.h = str;
    }

    public String getAuthorName() {
        return this.d;
    }

    public void setAuthorName(String str) {
        this.d = str;
    }

    public long getPackageSizeBytes() {
        return this.eo;
    }

    public void setPackageSizeBytes(long j) {
        this.eo = j;
    }

    public String getPermissionsUrl() {
        return this.zb;
    }

    public void setPermissionsUrl(String str) {
        this.zb = str;
    }

    public String getPrivacyAgreement() {
        return this.or;
    }

    public void setPrivacyAgreement(String str) {
        this.or = str;
    }

    public String getVersionName() {
        return this.cu;
    }

    public void setVersionName(String str) {
        this.cu = str;
    }

    public Map<String, String> getPermissionsMap() {
        return this.qp;
    }

    public void setPermissionsMap(Map<String, String> map) {
        this.qp = map;
    }

    public Map<String, Object> getAppInfoExtra() {
        return this.nb;
    }

    public void setAppInfoExtra(Map<String, Object> map) {
        this.nb = map;
    }

    public double getCpm() {
        try {
            if (isServerBiddingAd()) {
                if (getServerBiddingShowCpm() < 0.0d) {
                    return 0.0d;
                }
                return getServerBiddingShowCpm();
            }
            if (isClientBiddingAd() || isMultiBiddingAd()) {
                return this.rl * Double.valueOf(this.ny).doubleValue();
            }
            return this.rl;
        } catch (NumberFormatException e) {
            m.c(e);
        }
    }

    public String getDiscount() {
        return this.qy;
    }

    public void setDiscount(String str) {
        this.qy = str;
    }

    public double getStrategyCpm() {
        if (TextUtils.isEmpty(this.qy)) {
            return getCpm();
        }
        try {
            double d = Double.parseDouble(this.qy);
            if (d > 0.0d && d <= 100.0d) {
                return (getCpm() * d) / 100.0d;
            }
            return getCpm();
        } catch (Exception unused) {
            return getCpm();
        }
    }

    public void setCpm(double d) {
        this.rl = d;
    }

    public double getBiddingCpmWithOutExchangeRate() {
        if (!isServerBiddingAd()) {
            return this.rl;
        }
        if (getServerBiddingShowCpm() < 0.0d) {
            return 0.0d;
        }
        return getServerBiddingShowCpm();
    }

    public double getServerBiddingShowCpm() {
        return this.pf;
    }

    public void setServerBiddingShowCpm(double d) {
        this.pf = d;
    }

    public double getServerBiddingLoadCpm() {
        return this.bx;
    }

    public void setServerBiddingLoadCpm(double d) {
        this.bx = d;
    }

    public String getNetWorkPlatFormCpm() {
        if (isServerBiddingAd()) {
            return getServerBiddingShowCpm() < 0.0d ? "-1" : String.valueOf(getServerBiddingShowCpm());
        }
        return String.valueOf(getCpm());
    }

    public String getMultiCpm() {
        if (isServerBiddingAd()) {
            return getServerBiddingLoadCpm() < 0.0d ? "-1" : String.valueOf(getServerBiddingLoadCpm());
        }
        return String.valueOf(getCpm());
    }

    public boolean isServerBiddingAd() {
        return this.g == 2;
    }

    public boolean canAdReuse() {
        int i = this.g;
        return i == 0 || i == 100;
    }

    public boolean isClientBiddingAd() {
        return this.g == 1;
    }

    public boolean isMultiBiddingAd() {
        return this.g == 3;
    }

    public boolean isNormalAd() {
        return this.g == 0;
    }

    public boolean isPAd() {
        return this.g == 100;
    }

    public void setAdType(int i) {
        this.zm = i;
    }

    public int getAdNetworkSlotType() {
        return this.g;
    }

    public void setAdNetworkSlotType(int i) {
        this.g = i;
    }

    public void setShowSort(int i) {
        this.f = i;
    }

    public int getShowSort() {
        return this.f;
    }

    public void setLoadSort(int i) {
        this.ir = i;
    }

    public int getLoadSort() {
        return this.ir;
    }

    public List<String> getImages() {
        return this.my;
    }

    public void setImages(List<String> list) {
        if (list != null) {
            this.my.addAll(list);
        }
    }

    public void setIconUrl(String str) {
        this.da = str;
    }

    public String getIconUrl() {
        return this.da;
    }

    public String getImageUrl() {
        return this.sl;
    }

    public void setImageUrl(String str) {
        this.sl = str;
    }

    public int getImageWidth() {
        return this.t;
    }

    public void setImageWidth(int i) {
        this.t = i;
    }

    public int getImageHeight() {
        return this.u;
    }

    public void setImageHeight(int i) {
        this.u = i;
    }

    public String getActionText() {
        return this.m;
    }

    public void setActionText(String str) {
        this.m = str;
    }

    public String getPackageName() {
        return this.nu;
    }

    public void setPackageName(String str) {
        this.nu = str;
    }

    public void setAppSize(int i) {
        this.sv = i;
    }

    public int getAppSize() {
        return this.sv;
    }

    public int getAdType() {
        return this.zm;
    }

    public String getAdTitle() {
        return this.x;
    }

    public void setTitle(String str) {
        this.x = str;
    }

    public void setAdDescription(String str) {
        this.i = str;
    }

    public String getAdDescription() {
        return this.i;
    }

    public double getStarRating() {
        return this.rh;
    }

    public void setRating(double d) {
        this.rh = d;
    }

    public void setSource(String str) {
        this.gt = str;
    }

    public String getSource() {
        return this.gt;
    }

    public final boolean isReady(String str) {
        Integer numIsReadyStatus = isReadyStatus();
        if (numIsReadyStatus.intValue() == 1) {
            return !com.byazt.hk.c.c().c(str, this);
        }
        return numIsReadyStatus.intValue() == 2;
    }

    public Integer isReadyStatus() {
        return 1;
    }

    public void setVideoWidth(int i) {
        this.yp = i;
    }

    public int getVideoWidth() {
        return this.yp;
    }

    public void setVideoHeight(int i) {
        this.z = i;
    }

    public int getVideoHeight() {
        return this.z;
    }

    public boolean isCacheSuccess() {
        return this.mm;
    }

    public void setCacheSuccess(boolean z) {
        this.mm = z;
    }

    private void c(ViewGroup viewGroup, da daVar) {
        c(viewGroup);
        View viewFindViewById = viewGroup.findViewById(R.id.tt_mediation_mtg_ad_choice);
        if (viewFindViewById != null) {
            viewFindViewById.setVisibility(8);
        }
        if (daVar != null) {
            clearLogoView(viewGroup.findViewById(daVar.t));
        }
    }

    public void registerView(ViewGroup viewGroup, List<View> list, List<View> list2, List<View> list3, List<View> list4, View view) {
        c(viewGroup, null);
    }

    public void registerViewForInteraction(Activity activity, ViewGroup viewGroup, List<View> list, List<View> list2, List<View> list3, da daVar, List<View> list4) {
        if (list3 != null) {
            if (list2 == null) {
                list2 = new ArrayList<>();
            }
            list2.addAll(list3);
        }
        c(viewGroup, daVar);
    }

    public void clearLogoView(View view) {
        if (view != null) {
            view.setVisibility(0);
            if (view instanceof ViewGroup) {
                ((ViewGroup) view).removeAllViews();
            } else if (view instanceof ImageView) {
                ((ImageView) view).setImageDrawable(null);
            }
        }
    }

    public void removeSelfFromParent(View view) {
        if (view != null) {
            try {
                ViewParent parent = view.getParent();
                if (parent == null || !(parent instanceof ViewGroup)) {
                    return;
                }
                ((ViewGroup) parent).removeView(view);
            } catch (Exception e) {
                m.c(e);
            }
        }
    }

    private void c(ViewGroup viewGroup) {
        try {
            if (viewGroup.getChildCount() == 0 || getAdNetworkPlatformId() == 3) {
                return;
            }
            int i = 0;
            if (viewGroup.getChildAt(0) instanceof ViewGroup) {
                ViewGroup viewGroup2 = (ViewGroup) viewGroup.getChildAt(0);
                if (MediationConstant.TT_GDT_NATIVE_ROOT_VIEW_TAG.equals(viewGroup2.getTag(R.id.tt_mediation_gdt_developer_view_root_tag_key)) || MediationConstant.TT_GDT_NATIVE_ROOT_VIEW_TAG.equals(viewGroup2.getTag(2114387452))) {
                    viewGroup.removeView(viewGroup2);
                    while (i < viewGroup2.getChildCount()) {
                        View childAt = viewGroup2.getChildAt(i);
                        if (childAt == null || !(MediationConstant.TT_GDT_NATIVE_VIEW_TAG.equals(childAt.getTag(R.id.tt_mediation_gdt_developer_view_tag_key)) || MediationConstant.TT_GDT_NATIVE_VIEW_TAG.equals(childAt.getTag(2114387451)))) {
                            i++;
                        } else {
                            viewGroup2.removeView(childAt);
                            viewGroup.addView(childAt, childAt.getLayoutParams());
                        }
                    }
                }
            }
        } catch (Throwable th) {
            m.c(th);
        }
    }

    public void onDestroy() {
        this.c = null;
        this.tt = null;
        this.ve = null;
    }

    @Override // java.lang.Comparable
    public int compareTo(ve veVar) {
        if (veVar == null || this.ir > veVar.getLoadSort()) {
            return 1;
        }
        if (this.ir < veVar.getLoadSort()) {
            return -1;
        }
        if (this.f > veVar.getShowSort()) {
            return 1;
        }
        return this.f < veVar.getShowSort() ? -1 : 0;
    }

    public com.byazt.me.tt getGMNativeAdListener() {
        return this.c;
    }

    public com.byazt.fy.c getGMDrawAdListener() {
        return this.f1585a;
    }

    public x getGMVideoListener() {
        return this.tt;
    }

    public com.byazt.zh.tt getGMAdAppDownloadListener() {
        return this.ve;
    }

    public void setGMVideoRewardListener(i iVar) {
        this.n = iVar;
    }

    public void setGmShakeViewListener(n nVar) {
        this.uj = nVar;
    }

    public void setTTNativeAdListener(com.byazt.me.tt ttVar) {
        this.c = ttVar;
    }

    public void setTTVideoListener(x xVar) {
        this.tt = xVar;
    }

    public void setTTAdAppDownloadListener(final com.byazt.zh.tt ttVar) {
        if (ttVar != null) {
            this.ve = new com.byazt.zh.tt() { // from class: com.byazt.yl.ve.1
                @Override // com.byazt.zh.tt
                public void c() {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.1
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.c();
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void tt() {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.2
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.tt();
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void c(final long j, final long j2, final int i, final int i2, final String str, final String str2) {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.3
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.c(j, j2, i, i2, str, str2);
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void c(final long j, final long j2, final String str, final String str2) {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.4
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.c(j, j2, str, str2);
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void tt(final long j, final long j2, final String str, final String str2) {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.5
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.tt(j, j2, str, str2);
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void c(final long j, final String str, final String str2) {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.6
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.c(j, str, str2);
                        }
                    });
                }

                @Override // com.byazt.zh.tt
                public void c(final String str, final String str2) {
                    com.byazt.eu.n.ve(new Runnable() { // from class: com.byazt.yl.ve.1.7
                        @Override // java.lang.Runnable
                        public void run() {
                            ttVar.c(str, str2);
                        }
                    });
                }
            };
        }
    }

    public void setGMDrawAdListener(com.byazt.fy.c cVar) {
        this.f1585a = cVar;
    }

    public void setTTAdatperCallback(a aVar) {
        this.sp = aVar;
    }

    public a getTTAdatperCallback() {
        return this.sp;
    }

    public boolean isCustomAd() {
        return (this instanceof com.byazt.zm.tt) || (this instanceof com.byazt.uj.ve);
    }

    public void setDislikeCallback(Activity activity, com.byazt.dhf.c cVar) {
        this.w = cVar;
    }

    public com.byazt.dhf.c getDislikeCallback() {
        return this.w;
    }

    public boolean isLoadByDexPl() {
        return this.yf;
    }

    public void setLoadByDexPl(boolean z) {
        this.yf = z;
    }

    public c getCallBack() {
        return this.is;
    }

    public void setCallBack(c cVar) {
        this.is = cVar;
    }
}
