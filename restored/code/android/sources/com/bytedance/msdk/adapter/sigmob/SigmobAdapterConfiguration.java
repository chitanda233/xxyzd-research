package com.bytedance.msdk.adapter.sigmob;

import android.content.Context;
import android.location.Location;
import android.util.Log;
import android.util.SparseArray;
import com.bytedance.msdk.adapter.sigmob.base.MediationInitBaseFunction;
import com.bytedance.msdk.adapter.sigmob.base.config.IMediationLocation;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationInitConfig;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationApiLog;
import com.bytedance.msdk.adapter.sigmob.base.utils.MediationValueUtil;
import com.sigmob.windad.OnInitializationListener;
import com.sigmob.windad.OnStartListener;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobAdapterConfiguration extends MediationInitBaseFunction {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private volatile boolean f1866a = false;
    private boolean b = true;
    private MediationInitConfig c;

    private Object a() {
        try {
            return new WindCustomController() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobAdapterConfiguration.1
                @Override // com.sigmob.windad.WindCustomController
                public String getAndroidId() {
                    return SigmobAdapterConfiguration.this.c.getAndroidId();
                }

                @Override // com.sigmob.windad.WindCustomController
                public String getDevImei() {
                    return SigmobAdapterConfiguration.this.c.getDevImei();
                }

                @Override // com.sigmob.windad.WindCustomController
                public String getDevOaid() {
                    return SigmobAdapterConfiguration.this.c.getDevOaid();
                }

                @Override // com.sigmob.windad.WindCustomController
                public Location getLocation() {
                    IMediationLocation location = SigmobAdapterConfiguration.this.c.getLocation();
                    if (location == null) {
                        return null;
                    }
                    Location location2 = new Location("");
                    location2.setLongitude(location.getLongitude());
                    location2.setLatitude(location2.getLatitude());
                    return location2;
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUseAndroidId() {
                    try {
                        return SigmobAdapterConfiguration.this.c.isCanUseAndroidId();
                    } catch (Throwable th) {
                        th.printStackTrace();
                        return true;
                    }
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUseAppList() {
                    return SigmobAdapterConfiguration.this.c.appList();
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUseLocation() {
                    return SigmobAdapterConfiguration.this.c.isCanUseLocation();
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUseOaid() {
                    return SigmobAdapterConfiguration.this.c.isCanUseOaid();
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUsePhoneState() {
                    return SigmobAdapterConfiguration.this.c.isCanUsePhoneState();
                }

                @Override // com.sigmob.windad.WindCustomController
                public boolean isCanUseSpaceSize() {
                    SigmobAdapterConfiguration sigmobAdapterConfiguration = SigmobAdapterConfiguration.this;
                    boolean zA = sigmobAdapterConfiguration.a(sigmobAdapterConfiguration.c);
                    MediationApiLog.i("isCanUseSpaceSize: " + zA);
                    return zA;
                }
            };
        } catch (Throwable th) {
            th.printStackTrace();
            return null;
        }
    }

    private boolean a(Context context, String str, String str2, MediationInitConfig mediationInitConfig) {
        if (context != null && str != null) {
            try {
                final long jCurrentTimeMillis = System.currentTimeMillis();
                final WindAds windAdsSharedAds = WindAds.sharedAds();
                windAdsSharedAds.setPersonalizedAdvertisingOn(!this.c.isLimitPersonalAds());
                windAdsSharedAds.setAdult(this.b);
                WindAdOptions windAdOptions = new WindAdOptions(str, str2);
                try {
                    windAdOptions.setCustomController((WindCustomController) a());
                } catch (Throwable th) {
                    th.printStackTrace();
                }
                Log.i("Tme", "sigmob l:" + this.c.isCanUseLocation() + " a:" + this.c.appList() + " p:" + this.c.isCanUsePhoneState() + " o:" + this.c.isCanUseOaid() + " a:" + this.c.isCanUseAndroidId());
                if (a("4.21.1")) {
                    return windAdsSharedAds.init(context, windAdOptions, new OnInitializationListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobAdapterConfiguration.2
                        @Override // com.sigmob.windad.OnInitializationListener
                        public void onInitializationFail(String str3) {
                            SigmobAdapterConfiguration.this.notifyFail("sigmob init fail: " + str3);
                        }

                        @Override // com.sigmob.windad.OnInitializationListener
                        public void onInitializationSuccess() {
                            windAdsSharedAds.start(new OnStartListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobAdapterConfiguration.2.1
                                @Override // com.sigmob.windad.OnStartListener
                                public void onStartFail(String str3) {
                                    SigmobAdapterConfiguration.this.notifyInitTime(0, jCurrentTimeMillis, System.currentTimeMillis());
                                    SigmobAdapterConfiguration.this.notifyFail("sigmob start fail: " + str3);
                                }

                                @Override // com.sigmob.windad.OnStartListener
                                public void onStartSuccess() {
                                    SigmobAdapterConfiguration.this.notifyInitTime(1, jCurrentTimeMillis, System.currentTimeMillis());
                                    SigmobAdapterConfiguration.this.f1866a = true;
                                    SigmobAdapterConfiguration.this.notifySuccess();
                                }
                            });
                        }
                    });
                }
                notifyFail("sigmob init fail: version " + WindAds.getVersion() + " should be greater than 4.21.1");
                return false;
            } catch (Throwable unused) {
            }
        }
        return false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean a(MediationInitConfig mediationInitConfig) {
        if (mediationInitConfig == null) {
            return true;
        }
        try {
            Map<String, Object> mapUserPrivacyConfig = mediationInitConfig.userPrivacyConfig();
            if (mapUserPrivacyConfig == null) {
                return true;
            }
            Object obj = mapUserPrivacyConfig.get("isCanUseSpaceSize");
            if (obj instanceof Boolean) {
                return ((Boolean) obj).booleanValue();
            }
            if (obj instanceof Integer) {
                return ((Integer) obj).intValue() != 0;
            }
            return ((obj instanceof String) && "0".equals(obj)) ? false : true;
        } catch (Throwable unused) {
        }
    }

    private boolean a(String str) {
        return Utils.isSdkVersionGe(str);
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationInitBaseFunction
    public <T> T callFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        if (i == 8101) {
            return BuildConfig.ADAPTER_VERSION;
        }
        if (i == 8124) {
            this.c.setMediationCustomControllerValueSet(MediationValueUtil.objectValue(sparseArray.get(8517), Object.class, null));
            setPrivacyConfig();
        } else {
            if (i == 8102) {
                try {
                    return (T) WindAds.sharedAds().getSDKToken();
                } catch (Throwable th) {
                    th.printStackTrace();
                    return null;
                }
            }
            if (i == 8104) {
                try {
                    return (T) WindAds.getVersion();
                } catch (Throwable th2) {
                    th2.printStackTrace();
                    return "0.0";
                }
            }
            if (i == 8105) {
                return (T) this.c.getGromoreVersion();
            }
        }
        return null;
    }

    public String getNetworkSdkVersion() {
        return (String) call(8104, null, String.class);
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationInitBaseFunction
    public void realInitAdn(Context context, MediationInitConfig mediationInitConfig) {
        this.c = mediationInitConfig;
        synchronized (SigmobAdapterConfiguration.class) {
            if (this.f1866a) {
                notifySuccess();
            } else {
                a(context, mediationInitConfig.getAppId(), mediationInitConfig.getAppKey(), mediationInitConfig);
            }
        }
    }

    public void setPrivacyConfig() {
        if (this.c.getAgeGroup() != 0) {
            this.b = false;
        }
        try {
            if (this.f1866a) {
                WindAds windAdsSharedAds = WindAds.sharedAds();
                windAdsSharedAds.setPersonalizedAdvertisingOn(this.c.isLimitPersonalAds() ? false : true);
                windAdsSharedAds.setAdult(this.b);
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }
}
