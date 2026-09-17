package com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model;

import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public interface PbSCFeedPush {
    List<PbCommentFeed> getCommentFeeds();

    String getDisplayLikeCount();

    String getDisplayWatchingCount();

    List<PbSystemNoticeFeed> getSystemNoticeFeeds();
}
