package com.sigmob.sdk.manager;

import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.FrequencyControl;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import java.lang.ref.SoftReference;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3474a = "WindAdFCManager";
    private static volatile e b = null;
    private static final int c = -1;
    private final Map<String, Integer> d = new ConcurrentHashMap();
    private final Map<String, List<SoftReference<b>>> e = new ConcurrentHashMap();

    private e() {
    }

    public static e a() {
        if (b == null) {
            synchronized (e.class) {
                if (b == null) {
                    b = new e();
                }
            }
        }
        return b;
    }

    private void a(b manager, final String strategyId) {
        manager.a(AdStatus.AdStatusNone);
        d.a().c(manager);
        String strH = manager.h();
        final BaseAdUnit baseAdUnitE = manager.e();
        if (baseAdUnitE == null) {
            SigmobLogger.e(f3474a, "setInvalidManager: adUnit is unavailable.", new Object[0]);
            return;
        }
        final String requestId = baseAdUnitE.getRequestId();
        SigmobLogger.i(f3474a, "setInvalidManager: requestId = " + requestId + ", requestSceneType = " + baseAdUnitE.getRequestSceneType() + ", placementId = " + strH + ", simpleName = " + manager.getClass().getSimpleName(), new Object[0]);
        ad.a(PointCategory.SUBJECT_EXPIRE, (String) null, baseAdUnitE, new ad.a() { // from class: com.sigmob.sdk.manager.e$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                e.a(strategyId, baseAdUnitE, requestId, obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, BaseAdUnit baseAdUnit, String str2, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put(PointParamKey.STRATEGY_ID, str);
            options.put(PointParamKey.EXPIRE_RELOAD_COUNT, String.valueOf(baseAdUnit.expiredAdReloadNum()));
            String vid = baseAdUnit.getVid();
            String originVid = baseAdUnit.getOriginVid();
            if (s.b(originVid)) {
                vid = originVid;
            }
            options.put(PointParamKey.ORIGIN_VID, vid);
            String adxEncPrice = baseAdUnit.getAdxEncPrice();
            if (s.b(adxEncPrice)) {
                options.put(PointParamKey.ORIGIN_PRICE, adxEncPrice);
            }
            options.put(PointParamKey.REQUEST_ID, str2);
            pointEntitySigmob.setOptions(options);
        }
    }

    private boolean a(List<SoftReference<b>> softRefs, b manager) {
        if (!com.sigmob.sdk.base.utils.f.a(softRefs) && manager != null) {
            for (SoftReference<b> softReference : softRefs) {
                if (softReference != null && softReference.get() != null && softReference.get().equals(manager)) {
                    return true;
                }
            }
        }
        return false;
    }

    public String a(String strategyId, String fcEvent, Integer adType) {
        return strategyId + "-" + fcEvent + "-" + adType;
    }

    public synchronized void a(b manager) {
        if (manager == null) {
            return;
        }
        if (v.b(Boolean.valueOf(o.a().l()))) {
            return;
        }
        BaseAdUnit baseAdUnitE = manager.e();
        if (baseAdUnitE == null) {
            return;
        }
        List<FrequencyControl> frequencyControl = baseAdUnitE.getFrequencyControl();
        if (com.sigmob.sdk.base.utils.f.a(frequencyControl)) {
            return;
        }
        int ad_type = baseAdUnitE.getAd_type();
        for (FrequencyControl frequencyControl2 : frequencyControl) {
            String str = frequencyControl2.strategy_id;
            String str2 = frequencyControl2.frequency_control_event;
            Integer num = frequencyControl2.frequency_control_count;
            List<Integer> list = frequencyControl2.ad_expire_type;
            if (s.b(str) && s.b(str2) && v.a((Number) num) && com.sigmob.sdk.base.utils.f.b(list)) {
                Integer num2 = this.d.get(str);
                if (num2 == null || num2.intValue() == -1) {
                    this.d.put(str, num);
                }
                String strA = a(str, str2, Integer.valueOf(ad_type));
                List<SoftReference<b>> list2 = this.e.get(strA);
                if (list2 == null) {
                    ArrayList arrayList = new ArrayList();
                    this.e.put(strA, arrayList);
                    arrayList.add(new SoftReference(manager));
                    SigmobLogger.d(f3474a, "addAdManager: add", new Object[0]);
                } else {
                    boolean zA = a(list2, manager);
                    SigmobLogger.d(f3474a, "addAdManager: contains = " + zA, new Object[0]);
                    if (v.b(Boolean.valueOf(zA))) {
                        list2.add(new SoftReference<>(manager));
                    }
                }
            }
        }
    }

    public synchronized void a(String event, BaseAdUnit adUnit, b currentManager) {
        SigmobLogger.d(f3474a, "checkFrequencyControl: event = " + event, new Object[0]);
        if (!s.a((CharSequence) event) && adUnit != null) {
            List<FrequencyControl> frequencyControl = adUnit.getFrequencyControl();
            if (com.sigmob.sdk.base.utils.f.a(frequencyControl)) {
                SigmobLogger.e(f3474a, "checkFrequencyControl: frequency is unavailable.", new Object[0]);
                return;
            }
            for (FrequencyControl frequencyControl2 : frequencyControl) {
                String str = frequencyControl2.strategy_id;
                String str2 = frequencyControl2.frequency_control_event;
                Integer num = frequencyControl2.frequency_control_count;
                List<Integer> list = frequencyControl2.ad_expire_type;
                Integer numValueOf = this.d.get(str);
                boolean z = v.b(numValueOf) && s.a((CharSequence) event, (CharSequence) str2) && v.a((Number) num) && com.sigmob.sdk.base.utils.f.b(list);
                SigmobLogger.d(f3474a, "checkFrequencyControl: num = " + numValueOf + ", canCheck = " + z + ", strategyId = " + str + ", strategyEvent = " + str2 + ", strategyCount = " + num, new Object[0]);
                if (z) {
                    if (numValueOf.intValue() > 0) {
                        numValueOf = Integer.valueOf(numValueOf.intValue() - 1);
                        this.d.put(str, numValueOf);
                    }
                    if (numValueOf.intValue() <= 0) {
                        ArrayList<b> arrayList = new ArrayList();
                        Iterator<Integer> it = list.iterator();
                        while (it.hasNext()) {
                            String strA = a(str, str2, it.next());
                            List<SoftReference<b>> list2 = this.e.get(strA);
                            if (com.sigmob.sdk.base.utils.f.b(list2)) {
                                for (SoftReference<b> softReference : list2) {
                                    if (softReference != null && softReference.get() != null) {
                                        arrayList.add(softReference.get());
                                    }
                                }
                            }
                            this.e.remove(strA);
                        }
                        SigmobLogger.d(f3474a, "checkFrequencyControl: result = " + arrayList.remove(currentManager) + ", simpleName = " + currentManager.getClass().getSimpleName() + ", size = " + arrayList.size(), new Object[0]);
                        int i = 0;
                        for (b bVar : arrayList) {
                            BaseAdUnit baseAdUnitE = bVar.e();
                            if (baseAdUnitE == null) {
                                SigmobLogger.e(f3474a, "checkFrequencyControl: baseAdUnit is unavailable.", new Object[0]);
                            } else if (b.b(Integer.valueOf(baseAdUnitE.getRequestSceneType()))) {
                                SigmobLogger.e(f3474a, "checkFrequencyControl: unavailable requestSceneType.", new Object[0]);
                            } else {
                                a(bVar, str);
                                i++;
                            }
                        }
                        SigmobLogger.d(f3474a, "checkFrequencyControl: strategyId = " + str + ", expiredAdNum = " + i, new Object[0]);
                        if (i > 0) {
                            this.d.put(str, -1);
                        }
                    }
                }
            }
            return;
        }
        SigmobLogger.e(f3474a, "checkFrequencyControl: event or adUnit is unavailable.", new Object[0]);
    }
}
