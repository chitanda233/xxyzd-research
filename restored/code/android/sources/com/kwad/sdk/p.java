package com.kwad.sdk;

import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.model.SDKInitMsg;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class p {
    private static int aGO;

    public static void am(long j) {
        final long jCurrentTimeMillis = j > 0 ? System.currentTimeMillis() - j : -1L;
        aGO++;
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setLaunchIntervalTime(jCurrentTimeMillis).setInitCount(p.aGO).setInitStatus(0));
            }
        });
    }

    public static void an(final long j) {
        if (j > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            j = -1;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setTotalDurationTime(j).setInitCount(p.aGO).setInitStatus(1));
            }
        });
    }

    public static void ao(final long j) {
        if (j > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            j = -1;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setTotalDurationTime(j).setInitCount(p.aGO).setInitStatus(6));
            }
        });
    }

    public static void ap(final long j) {
        if (j > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            j = -1;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setTotalDurationTime(j).setInitCount(p.aGO).setInitStatus(3));
            }
        });
    }

    public static void aq(final long j) {
        if (j > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            j = -1;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setTotalDurationTime(j).setInitCount(p.aGO).setInitStatus(4));
            }
        });
    }

    public static void ar(final long j) {
        if (j > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT) {
            j = -1;
        }
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.6
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.APM_LOG, com.kwai.adclient.kscommerciallogger.model.a.buo, new SDKInitMsg().setTotalDurationTime(j).setInitCount(p.aGO).setInitStatus(5));
            }
        });
    }

    public static void a(final com.kwai.adclient.kscommerciallogger.model.d dVar, final String str) {
        com.kwad.sdk.utils.i.execute(new bi() { // from class: com.kwad.sdk.p.7
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.commercial.c.a(ILoggerReporter.Category.ERROR_LOG, dVar, new SDKInitMsg().setInitCount(p.aGO).setErrorReason(str).setInitStatus(2));
            }
        });
    }
}
