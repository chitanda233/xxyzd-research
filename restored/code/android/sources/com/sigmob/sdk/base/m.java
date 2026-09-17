package com.sigmob.sdk.base;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.Database.SQLiteBuider;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.Sigmob;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.z;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.models.WindAdMetaData;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmobRequest;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import com.sigmob.windad.WindAds;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public abstract class m {
    private static final HashMap<String, h> b = new HashMap<>();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private h f3220a;
    private boolean d;
    private String e;
    private int g;
    protected WindAdRequest l;
    protected AdStatus h = AdStatus.AdStatusNone;
    protected int i = 0;
    protected int j = 0;
    protected int k = 0;
    private int c = 0;
    private int f = 0;
    private String m = WindAds.CNY;

    protected m(WindAdRequest windAdRequest, boolean isHalfInterstitial) {
        this.l = windAdRequest;
        windAdRequest.setHalfInterstitial(isHalfInterstitial);
    }

    private h a(String placement) {
        h hVar = new h();
        Cursor cursorRawQuery = null;
        try {
            cursorRawQuery = com.sigmob.sdk.base.db.a.a().getReadableDatabase().rawQuery("select error_code, count(*) as num from adload_event where adslot_id = ? group by adslot_id", new String[]{placement});
            a(hVar, cursorRawQuery);
            if (cursorRawQuery != null && !cursorRawQuery.isClosed()) {
            }
        } catch (Throwable th) {
            try {
                SigmobLog.e(th.getMessage());
            } finally {
                if (cursorRawQuery != null && !cursorRawQuery.isClosed()) {
                    cursorRawQuery.close();
                }
            }
        }
        return hVar;
    }

    private void a() {
        this.i = 0;
        b(d());
        this.f3220a.a();
    }

    private void a(h loadFilterItem, Cursor cursor) {
        if (cursor == null || !cursor.moveToFirst()) {
            return;
        }
        int i = cursor.getInt(cursor.getColumnIndexOrThrow("error_code"));
        int i2 = cursor.getInt(cursor.getColumnIndexOrThrow("num"));
        do {
            if (i != 0) {
                loadFilterItem.f3215a = i2;
            }
            loadFilterItem.b += i2;
            switch (i) {
                case 600200:
                case 600201:
                case 600203:
                case 600204:
                    loadFilterItem.g = i2;
                    break;
                case 600900:
                    loadFilterItem.e = i2;
                    break;
                case 600905:
                    loadFilterItem.c = i2;
                    break;
                case 610012:
                    loadFilterItem.h = i2;
                    break;
                case 610013:
                    loadFilterItem.d = i2;
                    break;
            }
        } while (cursor.moveToNext());
    }

    private void a(final String placementId, final int error_code) {
        if (s.a((CharSequence) placementId)) {
            return;
        }
        try {
            SQLiteDatabase writableDatabase = com.sigmob.sdk.base.db.a.a().getWritableDatabase();
            SQLiteBuider.Insert.Builder builder = new SQLiteBuider.Insert.Builder();
            builder.setTableName(com.sigmob.sdk.base.db.a.f);
            HashMap map = new HashMap();
            map.put("adslot_id", placementId);
            map.put("error_code", Integer.valueOf(error_code));
            map.put(com.alipay.sdk.m.x.a.k, Long.valueOf(System.currentTimeMillis()));
            builder.setColumnValues(map);
            com.sigmob.sdk.base.db.a.a().a(writableDatabase, builder.build(), new com.sigmob.sdk.base.db.a.InterfaceC0557a() { // from class: com.sigmob.sdk.base.m.1
                @Override // com.sigmob.sdk.base.db.a.InterfaceC0557a
                public void a() {
                    SigmobLog.d(placementId + " insert load error event " + error_code + " onSuccess: ");
                }

                @Override // com.sigmob.sdk.base.db.a.InterfaceC0557a
                public void a(Throwable e) {
                    SigmobLog.e(placementId + " insert load error event " + error_code + " onFailed: ", e);
                }
            });
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, z zVar, Object obj) {
        if (obj instanceof PointEntitySigmobRequest) {
            PointEntitySigmobRequest pointEntitySigmobRequest = (PointEntitySigmobRequest) obj;
            pointEntitySigmobRequest.setLoad_count(String.valueOf(this.f3220a.b));
            pointEntitySigmobRequest.setInvalid_load_count(String.valueOf(this.f3220a.f3215a));
            pointEntitySigmobRequest.setGdpr_filters(String.valueOf(this.f3220a.c));
            pointEntitySigmobRequest.setInterval_filters(String.valueOf(this.f3220a.d));
            pointEntitySigmobRequest.setPldempty_filters(String.valueOf(this.i));
            pointEntitySigmobRequest.setInit_filters(String.valueOf(this.f3220a.e));
            pointEntitySigmobRequest.setLoading_filters(String.valueOf(this.f3220a.h));
            pointEntitySigmobRequest.setProguard_filters(String.valueOf(this.f3220a.g));
            pointEntitySigmobRequest.setAdx_id(null);
            if (s.b(this.e)) {
                pointEntitySigmobRequest.setBid_token(this.e);
            }
            if (s.b(str)) {
                pointEntitySigmobRequest.setTrace_id(str);
            }
            Map<String, String> options = pointEntitySigmobRequest.getOptions();
            if (v.b(zVar)) {
                options.put(PointParamKey.FEED_PRE_REQUEST_COUNT, String.valueOf(zVar.f3206a));
                options.put(PointParamKey.FEED_PRE_READY_COUNT, String.valueOf(zVar.b));
            }
            options.put(PointParamKey.IS_MINOR, i.a().d() ? "0" : "1");
            options.put(PointParamKey.IS_UNPERSONALIZED, i.a().e() ? "0" : "1");
            options.put(PointParamKey.PERSONALIZED_FILTERS, String.valueOf(this.f3220a.f));
            options.put(PointParamKey.REQUEST_SCENE_TYPE, String.valueOf(j.NormalRequest.a()));
            pointEntitySigmobRequest.setOptions(options);
        }
        a();
    }

    private void b(String placementId) {
        if (s.a((CharSequence) placementId)) {
            return;
        }
        try {
            com.sigmob.sdk.base.db.a.a().getWritableDatabase().delete(com.sigmob.sdk.base.db.a.f, "adslot_id=?", new String[]{placementId});
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }

    protected void a(final z loadCacheItem, final String traceId) {
        ad.a(PointCategory.REQUEST, "init", this.l, (LoadAdRequest) null, new ad.a() { // from class: com.sigmob.sdk.base.m$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(traceId, loadCacheItem, obj);
            }
        });
    }

    protected abstract void a(WindAdError adError);

    protected abstract void a(String key, String value);

    protected void a(boolean isBidType) {
        this.d = isBidType;
    }

    protected abstract Map<String, BiddingResponse> b();

    protected abstract com.sigmob.sdk.manager.b c();

    /* JADX INFO: Access modifiers changed from: protected */
    public String d() {
        WindAdRequest windAdRequest = this.l;
        if (windAdRequest == null) {
            return null;
        }
        return windAdRequest.getPlacementId();
    }

    protected Integer e() {
        WindAdRequest windAdRequest = this.l;
        if (windAdRequest == null) {
            return null;
        }
        return Integer.valueOf(windAdRequest.getAdType());
    }

    protected boolean f() {
        String strD = d();
        com.sigmob.sdk.manager.b bVarC = c();
        return !s.a((CharSequence) strD) && bVarC != null && this.h == AdStatus.AdStatusReady && bVarC.c();
    }

    /* JADX WARN: Code duplicated, block: B:35:0x00e8  */
    /* JADX WARN: Code duplicated, block: B:39:0x00fa  */
    /* JADX WARN: Code duplicated, block: B:40:0x0100  */
    /* JADX WARN: Code duplicated, block: B:42:0x010c  */
    /* JADX WARN: Code duplicated, block: B:44:0x0110  */
    /* JADX WARN: Code duplicated, block: B:45:0x0116  */
    /* JADX WARN: Code duplicated, block: B:48:0x0131  */
    protected boolean g() {
        WindAdError sigMobError;
        String str;
        h hVar;
        if (com.sigmob.sdk.b.e() != null) {
            com.sigmob.sdk.b.a(true);
            WindAdRequest windAdRequest = this.l;
            if (windAdRequest == null || s.a((CharSequence) windAdRequest.getPlacementId())) {
                sigMobError = WindAdError.ERROR_SIGMOB_PLACEMENTID_EMPTY;
                this.i++;
                str = "PlacementId with WindAdRequest can't is null";
            } else {
                HashMap<String, h> map = b;
                h hVar2 = map.get(d());
                this.f3220a = hVar2;
                if (hVar2 == null) {
                    h hVarA = a(d());
                    this.f3220a = hVarA;
                    hVarA.e = this.j;
                    this.f3220a.f = this.f;
                    map.put(d(), this.f3220a);
                }
                if (this.d && s.a((CharSequence) this.e)) {
                    this.f3220a.i++;
                    sigMobError = WindAdError.ERROR_SIGMOB_BID_TOKEN_IS_EMPTY;
                } else if (this.h == AdStatus.AdStatusReady) {
                    sigMobError = null;
                } else if (this.h == AdStatus.AdStatusLoading) {
                    this.f3220a.h++;
                    sigMobError = WindAdError.ERROR_AD_LOAD_FAIL_LOADING;
                } else if (Sigmob.getInstance().getSigMobError() != null) {
                    sigMobError = Sigmob.getInstance().getSigMobError();
                    this.f3220a.g++;
                } else if (!i.a().i()) {
                    SigmobLog.e("User GDPR Consent Status is denied");
                    sigMobError = WindAdError.ERROR_SIGMOB_GDPR_DENIED;
                    this.f3220a.c++;
                } else if (o.a().O() <= 0 || o.a().O() + this.f3220a.j <= System.currentTimeMillis()) {
                    sigMobError = null;
                } else {
                    SigmobLog.e("load interval Time error");
                    this.f3220a.d++;
                    sigMobError = WindAdError.ERROR_AD_LOAD_FAIL_INTERVAL;
                }
            }
            hVar = this.f3220a;
            if (hVar == null) {
                this.k++;
            } else {
                hVar.b += this.k + 1;
                this.k = 0;
            }
            if (sigMobError != null) {
                ClientMetadata.setUserId(this.l.getUserId());
                return true;
            }
            if (this.f3220a == null) {
                this.c++;
            } else {
                a(d(), sigMobError.getErrorCode());
                this.f3220a.f3215a += this.c + 1;
                this.c = 0;
            }
            a(sigMobError);
            return false;
        }
        this.j++;
        sigMobError = WindAdError.ERROR_SIGMOB_NOT_START;
        str = "WindAds not start";
        SigmobLog.e(str);
        hVar = this.f3220a;
        if (hVar == null) {
            this.k++;
        } else {
            hVar.b += this.k + 1;
            this.k = 0;
        }
        if (sigMobError != null) {
            ClientMetadata.setUserId(this.l.getUserId());
            return true;
        }
        if (this.f3220a == null) {
            this.c++;
        } else {
            a(d(), sigMobError.getErrorCode());
            this.f3220a.f3215a += this.c + 1;
            this.c = 0;
        }
        a(sigMobError);
        return false;
    }

    public int getBidFloor() {
        return this.g;
    }

    public String getBid_token() {
        return this.e;
    }

    public abstract String getCurrency();

    public abstract String getEcpm();

    public Map<String, String> getSaasOptions() {
        com.sigmob.sdk.manager.b bVarC = c();
        if (bVarC == null) {
            return null;
        }
        BaseAdUnit baseAdUnitI = bVarC.i();
        BaseAdUnit baseAdUnitE = bVarC.e();
        if (baseAdUnitI == null) {
            baseAdUnitI = baseAdUnitE;
        }
        if (baseAdUnitI == null) {
            return null;
        }
        return baseAdUnitI.getSaasOptions();
    }

    public WindAdMetaData getWindAdMetaData() {
        com.sigmob.sdk.manager.b bVarC = c();
        if (bVarC == null) {
            return null;
        }
        BaseAdUnit baseAdUnitI = bVarC.i();
        if (baseAdUnitI == null) {
            baseAdUnitI = bVarC.e();
        }
        return WindAdMetaData.create(baseAdUnitI);
    }

    protected String h() {
        return this.m;
    }

    public boolean loadAd() {
        this.d = false;
        this.e = null;
        return false;
    }

    public boolean loadAd(String bidToken) {
        this.d = true;
        this.e = bidToken;
        SigmobLog.d("loadAd: bidToken = " + bidToken);
        return false;
    }

    public void sendLossNotificationWithInfo(Map<String, Object> lossInfo) {
        String strValueOf;
        try {
            Map<String, BiddingResponse> mapB = b();
            if (mapB == null) {
                return;
            }
            Set<String> setKeySet = mapB.keySet();
            if (com.sigmob.sdk.base.utils.f.a(setKeySet)) {
                return;
            }
            for (String str : setKeySet) {
                BiddingResponse biddingResponse = mapB.get(str);
                if (biddingResponse != null) {
                    String strReplace = biddingResponse.lose_url;
                    if (!s.a((CharSequence) strReplace)) {
                        if (com.sigmob.sdk.base.utils.f.b(lossInfo)) {
                            if (lossInfo.get(WindAds.AUCTION_PRICE) != null) {
                                a(SigMacroCommon._PUBLISHERPRICE_, String.valueOf(lossInfo.get(WindAds.AUCTION_PRICE)));
                                strReplace = strReplace.replace("__AUCTION_PRICE__", String.valueOf(lossInfo.get(WindAds.AUCTION_PRICE)));
                            }
                            if (lossInfo.get(WindAds.CURRENCY) != null) {
                                a(SigMacroCommon._CURRENCY_, String.valueOf(lossInfo.get(WindAds.CURRENCY)));
                                strValueOf = String.valueOf(lossInfo.get(WindAds.CURRENCY));
                            } else {
                                a(SigMacroCommon._CURRENCY_, this.m);
                                strValueOf = this.m;
                            }
                            strReplace = strReplace.replace("__CURRENCY__", strValueOf);
                            if (lossInfo.get(WindAds.LOSS_REASON) != null) {
                                strReplace = strReplace.replace("_BIDLOSSCODE_", String.valueOf(lossInfo.get(WindAds.LOSS_REASON)));
                            }
                            if (lossInfo.get(WindAds.ADN_ID) != null) {
                                strReplace = strReplace.replace("_WINADNID_", String.valueOf(lossInfo.get(WindAds.ADN_ID)));
                            }
                        }
                        com.sigmob.sdk.base.network.b.a(strReplace, PointCategory.LOSE, this.l, str);
                    }
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void sendWinNotificationWithInfo(Map<String, Object> winInfo) {
        String strValueOf;
        try {
            Map<String, BiddingResponse> mapB = b();
            if (mapB == null) {
                return;
            }
            Set<String> setKeySet = mapB.keySet();
            if (com.sigmob.sdk.base.utils.f.a(setKeySet)) {
                return;
            }
            for (String str : setKeySet) {
                BiddingResponse biddingResponse = mapB.get(str);
                if (biddingResponse != null) {
                    String strReplace = biddingResponse.win_url;
                    if (!s.a((CharSequence) strReplace)) {
                        if (com.sigmob.sdk.base.utils.f.b(winInfo)) {
                            if (winInfo.get(WindAds.AUCTION_PRICE) != null) {
                                a(SigMacroCommon._PUBLISHERPRICE_, String.valueOf(winInfo.get(WindAds.AUCTION_PRICE)));
                                strReplace = strReplace.replace("__AUCTION_PRICE__", String.valueOf(winInfo.get(WindAds.AUCTION_PRICE)));
                            }
                            if (winInfo.get(WindAds.HIGHEST_LOSS_PRICE) != null) {
                                a(SigMacroCommon._HIGHESTLOSSPRICE_, String.valueOf(winInfo.get(WindAds.HIGHEST_LOSS_PRICE)));
                                strReplace = strReplace.replace("__HIGHEST_LOSS_PRICE__", String.valueOf(winInfo.get(WindAds.HIGHEST_LOSS_PRICE)));
                            }
                            if (winInfo.get(WindAds.CURRENCY) != null) {
                                a(SigMacroCommon._CURRENCY_, String.valueOf(winInfo.get(WindAds.CURRENCY)));
                                strValueOf = String.valueOf(winInfo.get(WindAds.CURRENCY));
                            } else {
                                a(SigMacroCommon._CURRENCY_, this.m);
                                strValueOf = this.m;
                            }
                            strReplace = strReplace.replace("__CURRENCY__", strValueOf);
                        }
                        com.sigmob.sdk.base.network.b.a(strReplace, PointCategory.WIN, this.l, str);
                    }
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void setBidEcpm(int bidEcpm) {
        a(SigMacroCommon._PUBLISHERPRICE_, String.valueOf(bidEcpm));
    }

    public void setBidFloor(int bidFloor) {
        this.g = bidFloor;
        com.sigmob.sdk.manager.b bVarC = c();
        if (bVarC == null) {
            return;
        }
        bVarC.d(Integer.valueOf(bidFloor));
    }

    public void setCurrency(String currency) {
        this.m = currency;
        com.sigmob.sdk.manager.b bVarC = c();
        if (bVarC == null) {
            return;
        }
        bVarC.a(currency);
    }
}
